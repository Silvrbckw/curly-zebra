﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.KeyVault.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.Storage.Fluent;
using Microsoft.Azure.Management.Graph.RBAC.Fluent;

namespace Microsoft.Azure.Management.AppService.Fluent
{
    /// <summary>
    /// Entry point to Azure app service management.
    /// </summary>
    public class AppServiceManager : Manager<IWebSiteManagementClient>, IAppServiceManager, IBeta
    {
        private IKeyVaultManager keyVaultManager;
        private IStorageManager storageManager;
        private IGraphRbacManager graphRbacManager;
        private string tenantId;
        private RestClient restClient;

        #region Fluent private collections
        private IAppServicePlans appServicePlans;
        private IWebApps webApps;
        private IFunctionApps functionApps;
        private IAppServiceDomains appServiceDomains;
        private IAppServiceCertificates appServiceCertificates;
        private IAppServiceCertificateOrders appServiceCertificateOrders;
        #endregion

        #region ctrs

        public AppServiceManager(RestClient restClient, string subscriptionId, string tenantId) :
            base(restClient, subscriptionId, WebSiteManagementClient.NewInstance(restClient))
        {
            Inner.SubscriptionId = subscriptionId;
            keyVaultManager = KeyVault.Fluent.KeyVaultManager.Authenticate(restClient, subscriptionId, tenantId);
            storageManager = Storage.Fluent.StorageManager.Authenticate(restClient, subscriptionId);
            graphRbacManager = Graph.RBAC.Fluent.GraphRbacManager.Authenticate(restClient, tenantId);
            this.tenantId = tenantId;
            this.restClient = restClient;
        }

        #endregion

        #region App Service Manager builder

        public static IAppServiceManager Authenticate(AzureCredentials credentials, string subscriptionId)
        {
            return new AppServiceManager(RestClient.Configure()
                    .WithEnvironment(credentials.Environment)
                    .WithCredentials(credentials)
                    .WithDelegatingHandler(new ProviderRegistrationDelegatingHandler(credentials))
                    .Build(), subscriptionId, credentials.TenantId);
        }

        public static IAppServiceManager Authenticate(RestClient restClient, string subscriptionId, string tenantId)
        {
            return new AppServiceManager(restClient, subscriptionId, tenantId);
        }

        public static IConfigurable Configure()
        {
            return new Configurable();
        }

        #endregion


        #region IConfigurable and it's implementation

        public interface IConfigurable : IAzureConfigurable<IConfigurable>
        {
            IAppServiceManager Authenticate(AzureCredentials credentials, string subscriptionId);
        }

        protected class Configurable :
            AzureConfigurable<IConfigurable>,
            IConfigurable
        {
            public IAppServiceManager Authenticate(AzureCredentials credentials, string subscriptionId)
            {
                return new AppServiceManager(BuildRestClient(credentials), subscriptionId, credentials.TenantId);
            }
        }

        #endregion

        #region IAppServiceManager implementation 

        public IAppServicePlans AppServicePlans
        {
            get
            {
                if (appServicePlans == null)
                {
                    appServicePlans = new AppServicePlansImpl(this);
                }
                return appServicePlans;
            }
        }

        public IWebApps WebApps
        {
            get
            {
                if (webApps == null)
                {
                    webApps = new WebAppsImpl(this);
                }
                return webApps;
            }
        }

        public IFunctionApps FunctionApps
        {
            get
            {
                if (functionApps == null)
                {
                    functionApps = new FunctionAppsImpl(this);
                }
                return functionApps;
            }
        }

        public IAppServiceDomains AppServiceDomains
        {
            get
            {
                if (appServiceDomains == null)
                {
                    appServiceDomains = new AppServiceDomainsImpl(this);
                }
                return appServiceDomains;
            }
        }

        public IAppServiceCertificates AppServiceCertificates
        {
            get
            {
                if (appServiceCertificates == null)
                {
                    appServiceCertificates = new AppServiceCertificatesImpl(this);
                }
                return appServiceCertificates;
            }
        }

        public IAppServiceCertificateOrders AppServiceCertificateOrders
        {
            get
            {
                if (appServiceCertificateOrders == null)
                {
                    appServiceCertificateOrders = new AppServiceCertificateOrdersImpl(this);
                }
                return appServiceCertificateOrders;
            }
        }

        public IKeyVaultManager KeyVaultManager
        {
            get
            {
                return keyVaultManager;
            }
        }

        public IStorageManager StorageManager
        {
            get
            {
                return storageManager;
            }
        }

        public IGraphRbacManager GraphRbacManager
        {
            get
            {
                return graphRbacManager;
            }
        }

        #endregion
    }

    public interface IAppServiceManager : IManager<IWebSiteManagementClient>
    {
        IAppServicePlans AppServicePlans { get; }
        IWebApps WebApps { get; }
        IFunctionApps FunctionApps { get; }
        IAppServiceDomains AppServiceDomains { get; }
        IAppServiceCertificates AppServiceCertificates { get; }
        IAppServiceCertificateOrders AppServiceCertificateOrders { get; }
        IKeyVaultManager KeyVaultManager { get; }
        IStorageManager StorageManager { get; }
        IGraphRbacManager GraphRbacManager { get; }
    }
}
