﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using System;
using System.Linq;

namespace Microsoft.Azure.Management.Cdn.Fluent
{
    public class CdnManager : Manager<ICdnManagementClient>, ICdnManager
    {
        #region Fluent private collections
        private ICdnProfiles profiles;
        #endregion

        public CdnManager(RestClient restClient, string subscriptionId) :
            base(restClient, subscriptionId, CdnManagementClient.NewInstance(restClient))
        {
            Inner.SubscriptionId = subscriptionId;
        }

        public static ICdnManager Authenticate(AzureCredentials credentials, string subscriptionId)
        {
            return new CdnManager(RestClient.Configure()
                    .WithEnvironment(credentials.Environment)
                    .WithCredentials(credentials)
                    .WithDelegatingHandler(new ProviderRegistrationDelegatingHandler(credentials))
                    .Build(), subscriptionId);
        }

        public static ICdnManager Authenticate(RestClient restClient, string subscriptionId)
        {
            return new CdnManager(restClient, subscriptionId);
        }

        public static IConfigurable Configure()
        {
            return new Configurable();
        }


        #region IConfigurable and it's implementation

        public interface IConfigurable : IAzureConfigurable<IConfigurable>
        {
            ICdnManager Authenticate(AzureCredentials credentials, string subscriptionId);
        }

        protected class Configurable :
            AzureConfigurable<IConfigurable>,
            IConfigurable
        {
            public ICdnManager Authenticate(AzureCredentials credentials, string subscriptionId)
            {
                return new CdnManager(BuildRestClient(credentials), subscriptionId);
            }
        }

        #endregion

        public ICdnProfiles Profiles
        {
            get
            {
                if (profiles == null)
                {
                    profiles = new CdnProfilesImpl(this);
                }
                return profiles;
            }
        }
    }

    public interface ICdnManager : IManager<ICdnManagementClient>
    {
        ICdnProfiles Profiles { get; }
    }
}
