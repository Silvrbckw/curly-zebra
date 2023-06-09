﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Azure.Tests;
using Fluent.Tests.Common;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Linq;
using Xunit;

namespace Fluent.Tests.ResourceManager
{
    public class Deployment
    {
        private string rgName = "rgchash12";
        private string deploymentName1 = "deployment1";
        private string deploymentName2 = "deployment2";
        private string deploymentName3 = "deployment3";
        private string templateUri = "https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/quickstarts/microsoft.network/vnet-two-subnets/azuredeploy.json";
        private string parametersUri = "https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/quickstarts/microsoft.network/vnet-two-subnets/azuredeploy.parameters.json";
        private string updateTemplate = "{\"$schema\":\"https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#\",\"contentVersion\":\"1.0.0.0\",\"parameters\":{\"vnetName\":{\"type\":\"string\",\"defaultValue\":\"VNet2\",\"metadata\":{\"description\":\"VNet name\"}},\"vnetAddressPrefix\":{\"type\":\"string\",\"defaultValue\":\"10.0.0.0/16\",\"metadata\":{\"description\":\"Address prefix\"}},\"subnet1Prefix\":{\"type\":\"string\",\"defaultValue\":\"10.0.0.0/24\",\"metadata\":{\"description\":\"Subnet 1 Prefix\"}},\"subnet1Name\":{\"type\":\"string\",\"defaultValue\":\"Subnet1\",\"metadata\":{\"description\":\"Subnet 1 Name\"}},\"subnet2Prefix\":{\"type\":\"string\",\"defaultValue\":\"10.0.1.0/24\",\"metadata\":{\"description\":\"Subnet 2 Prefix\"}},\"subnet2Name\":{\"type\":\"string\",\"defaultValue\":\"Subnet222\",\"metadata\":{\"description\":\"Subnet 2 Name\"}}},\"variables\":{\"apiVersion\":\"2015-06-15\"},\"resources\":[{\"apiVersion\":\"[variables('apiVersion')]\",\"type\":\"Microsoft.Network/virtualNetworks\",\"name\":\"[parameters('vnetName')]\",\"location\":\"[resourceGroup().location]\",\"properties\":{\"addressSpace\":{\"addressPrefixes\":[\"[parameters('vnetAddressPrefix')]\"]},\"subnets\":[{\"name\":\"[parameters('subnet1Name')]\",\"properties\":{\"addressPrefix\":\"[parameters('subnet1Prefix')]\"}},{\"name\":\"[parameters('subnet2Name')]\",\"properties\":{\"addressPrefix\":\"[parameters('subnet2Prefix')]\"}}]}}]}";
        private string updateParameters = "{\"vnetAddressPrefix\":{\"value\":\"10.0.0.0/16\"},\"subnet1Name\":{\"value\":\"Subnet1\"},\"subnet1Prefix\":{\"value\":\"10.0.0.0/24\"}}";
        private string contentVersion = "1.0.0.0";

        [Fact]
        public void CanCreateVirtualNetwork()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                IResourceManager resourceManager = TestHelper.CreateResourceManager();

                try
                {
                    resourceManager.Deployments
                        .Define(deploymentName1)
                        .WithNewResourceGroup(rgName, Region.USEast)
                        .WithTemplateLink(templateUri, contentVersion)
                        .WithParametersLink(parametersUri, contentVersion)
                        .WithMode(DeploymentMode.Complete)
                        .Create();

                    // List
                    var deployments = resourceManager.Deployments.ListByResourceGroup(rgName);
                    var found = from dep in deployments
                                where dep.Name.Equals(deploymentName1, StringComparison.OrdinalIgnoreCase)
                                select dep;

                    Assert.True(found != null);

                    // Check existence
                    Assert.True(resourceManager.Deployments.CheckExistence(rgName, deploymentName1));

                    // Get
                    var deployment = resourceManager.Deployments.GetByResourceGroup(rgName, deploymentName1);
                    Assert.True(deployment != null);
                    Assert.True(deployment.ProvisioningState != null);

                    // Try export template from deployment object
                    var exportedDeployment = deployment.ExportTemplate();
                    Assert.True(exportedDeployment.Template != null);

                    // Try export template using resourcegroup
                    var resourceGroup = resourceManager.ResourceGroups.GetByName(rgName);
                    var exportedRG = resourceGroup.ExportTemplate(ResourceGroupExportTemplateOptions.IncludeBoth);
                    Assert.True(exportedRG.Template != null);

                    // Deployment operations
                    var deploymentOperations = deployment.DeploymentOperations.List();
                    Assert.Equal(5, deploymentOperations.Count());
                    IDeploymentOperation deploymentOperation = deployment.DeploymentOperations.GetById(deploymentOperations.First().OperationId);
                    Assert.NotNull(deploymentOperation);

                    resourceManager.GenericResources.Delete(rgName, "Microsoft.Network", "", "virtualnetworks", "VNet1", "2020-11-01");
                }
                finally
                {
                    try
                    {
                        TestHelper.CreateResourceManager().ResourceGroups.DeleteByName(rgName);
                    }
                    catch { }
                }
            }
        }

        [Fact]
        public void CanCancelVirtualNetworkDeployment()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                IResourceManager resourceManager = TestHelper.CreateResourceManager();
                try
                {
                    var createdDeployment = resourceManager.Deployments
                        .Define(deploymentName2)
                        .WithNewResourceGroup(rgName, Region.USEast)
                        .WithTemplateLink(templateUri, contentVersion)
                        .WithParametersLink(parametersUri, contentVersion)
                        .WithMode(DeploymentMode.Complete)
                        .BeginCreateAsync().Result;
                    var deployment = resourceManager.Deployments.GetByResourceGroup(rgName, deploymentName2);
                    Assert.Equal(createdDeployment.CorrelationId, deployment.CorrelationId);
                    Assert.Equal(deployment.Name, deploymentName2);
                    deployment.Cancel();
                    deployment = resourceManager.Deployments.GetByResourceGroup(rgName, deploymentName2);
                    Assert.Equal(ProvisioningState.Canceled, deployment.ProvisioningState);
                    resourceManager.GenericResources.Delete(rgName, "Microsoft.Network", "", "virtualnetworks", "VNet1", "2020-11-01");
                }
                finally
                {
                    try
                    {
                        TestHelper.CreateResourceManager().ResourceGroups.DeleteByName(rgName);
                    }
                    catch { }
                }
            }
        }

        [Fact]
        public void CanUpdateVirtualNetworkDeployment()
        {
            using (var context = FluentMockContext.Start(this.GetType().FullName))
            {
                IResourceManager resourceManager = TestHelper.CreateResourceManager();

                try
                {
                    var deployment = resourceManager.Deployments
                        .Define(deploymentName3)
                        .WithNewResourceGroup(rgName, Region.USEast)
                        .WithTemplateLink(templateUri, contentVersion)
                        .WithParametersLink(parametersUri, contentVersion)
                        .WithMode(DeploymentMode.Complete)
                        .BeginCreate();
                    Assert.Equal(deploymentName3, deployment.Name);
                    deployment.Cancel();
                    deployment = resourceManager.Deployments.GetByResourceGroup(rgName, deploymentName3);
                    Assert.Equal(ProvisioningState.Canceled, deployment.ProvisioningState);

                    deployment.Update()
                        .WithTemplate(updateTemplate)
                        .WithParameters(updateParameters)
                        .WithMode(DeploymentMode.Incremental)
                        .Apply();
                    deployment = resourceManager.Deployments.GetByResourceGroup(rgName, deploymentName3);
                    Assert.True(deployment.Mode == DeploymentMode.Incremental);
                    Assert.Equal(ProvisioningState.Succeeded, deployment.ProvisioningState);

                    IGenericResource genericVnet = resourceManager.GenericResources.Get(
                        rgName,
                        "Microsoft.Network",
                        "",
                        "virtualnetworks",
                        "VNet2",
                        "2020-11-01");
                    Assert.NotNull(genericVnet);
                    resourceManager.GenericResources.Delete(
                        rgName,
                        "Microsoft.Network",
                        "",
                        "virtualnetworks",
                        "VNet2",
                        "2020-11-01");
                }
                finally
                {
                    try
                    {
                        TestHelper.CreateResourceManager().ResourceGroups.DeleteByName(rgName);
                    }
                    catch { }
                }
            }
        }
    }
}
