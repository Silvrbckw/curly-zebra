﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.GenericResource.Definition;
using Microsoft.Azure.Management.ResourceManager.Fluent.GenericResource.Update;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using System.Threading;
using System.Threading.Tasks;
using System;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    internal class GenericResourceImpl : GroupableResource<IGenericResource,
        GenericResourceInner,
        GenericResourceImpl,
        IResourceManager,
        IWithGroup,
        IWithResourceType,
        GenericResource.Definition.IWithCreate,
        GenericResource.Update.IUpdate>,
        IGenericResource,
        GenericResource.Definition.IDefintion,
        GenericResource.Update.IUpdate,
        GenericResource.Update.IWithApiVersion
    {
        internal string resourceProviderNamespace;
        internal string parentResourceId;
        internal string resourceType;
        internal string apiVersion;

        private GenericResourceInner updateParameter = new GenericResourceInner();

        #region Getters

        public string ResourceProviderNamespace
        {
            get
            {
                return resourceProviderNamespace;
            }
        }

        public string ParentResourceId
        {
            get
            {
                return parentResourceId;
            }
        }

        public string ResourceType
        {
            get
            {
                return resourceType;
            }
        }

        public string ApiVersion
        {
            get
            {
                if (string.IsNullOrEmpty(apiVersion))
                {
                    apiVersion = GenericResourcesImpl.GetApiVersion(Id, Manager);
                }
                return apiVersion;
            }
        }

        public Plan Plan
        {
            get
            {
                return Inner.Plan;
            }
        }

        public object Properties
        {
            get
            {
                return Inner.Properties;
            }
        }

        #endregion

        internal GenericResourceImpl(string key,
            GenericResourceInner innerModel,
            IResourceManager resourceManager) : base(key, innerModel, resourceManager)
        {
        }

        public void prepareDefaultValue()
        {
            this.parentResourceId = this.parentResourceId ?? "";
        }

        #region Implementation of IResourceCreator interface

        public async override Task<IGenericResource> CreateResourceAsync(CancellationToken cancellationToken)
        {
            prepareDefaultValue();
            if (string.IsNullOrEmpty(apiVersion))
            {
                string resourceId = ResourceUtils.ConstructResourceId(Manager.Inner.SubscriptionId, ResourceGroupName, resourceProviderNamespace, resourceType, Name, parentResourceId);
                apiVersion = await GenericResourcesImpl.GetApiVersionAsync(resourceId, Manager, cancellationToken);
            }
            if (IsInCreateMode)
            {
                GenericResourceInner inner = await Manager.Inner.Resources.CreateOrUpdateAsync(ResourceGroupName,
                    resourceProviderNamespace,
                    parentResourceId,
                    resourceType,
                    Name,
                    apiVersion,
                    Inner,
                    cancellationToken);
                SetInner(inner);
            }
            else
            {
                updateParameter.Tags = Inner.Tags;
                GenericResourceInner inner = await Manager.Inner.Resources.UpdateAsync(ResourceGroupName,
                    resourceProviderNamespace,
                    parentResourceId,
                    resourceType,
                    Name,
                    apiVersion,
                    updateParameter,
                    cancellationToken);
                SetInner(inner);
            }
            return this;
        }

        #endregion

        protected override async Task<GenericResourceInner> GetInnerAsync(CancellationToken cancellationToken)
        {
            return await Manager.Inner.Resources.GetAsync(ResourceGroupName,
                resourceProviderNamespace,
                parentResourceId,
                resourceType,
                Name,
                apiVersion,
                cancellationToken);
        }

        public new GenericResource.Update.IWithApiVersion Update()
        {
            updateParameter = new GenericResourceInner();
            base.Update();
            return this;
        }

        #region Setters

        #region Definition Setters

        public IWithProviderNamespace WithResourceType(string resourceType)
        {
            this.resourceType = resourceType;
            return this;
        }

        public GenericResource.Definition.IWithPlan WithProviderNamespace(string resourceProviderNamespace)
        {
            this.resourceProviderNamespace = resourceProviderNamespace;
            return this;
        }

        public IWithCreate WithApiVersion(string apiVersion = default(string))
        {
            this.apiVersion = apiVersion;
            return this;
        }

        public IWithCreate WithProperties(object properties)
        {
            Inner.Properties = properties;
            return this;
        }

        public GenericResource.Definition.IWithCreate WithParentResource(string parentResourceId)
        {
            this.parentResourceId = parentResourceId;
            return this;
        }

        public GenericResource.Definition.IWithApiVersion WithPlan(string name, string publisher, string product, string promotionCode)
        {
            Inner.Plan = new Plan
            {
                Name = name,
                Publisher = publisher,
                Product = product,
                PromotionCode = promotionCode
            };
            return this;
        }

        public GenericResource.Definition.IWithApiVersion WithoutPlan()
        {
            Inner.Plan = null;
            return this;
        }

        #endregion

        #region Update setters


        IUpdate GenericResource.Update.IWithPlan.WithPlan(string name, string publisher, string product, string promotionCode)
        {
            updateParameter.Plan = new Plan
            {
                Name = name,
                Publisher = publisher,
                Product = product,
                PromotionCode = promotionCode
            };
            return this;
        }

        IUpdate GenericResource.Update.IWithParentResource.WithParentResource(string parentResourceId)
        {
            this.parentResourceId = parentResourceId;
            return this;
        }

        IUpdate IWithProperties.WithProperties(object properties)
        {
            updateParameter.Properties = properties;
            return this;
        }

        IUpdate GenericResource.Update.IWithApiVersion.WithApiVersion(string apiVersion)
        {
            this.apiVersion = apiVersion;
            return this;
        }

        IUpdate GenericResource.Update.IWithPlan.WithoutPlan()
        {
            updateParameter.Plan = null;
            return this;
        }

        #endregion

        #endregion
    }
}
