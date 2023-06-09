﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.ResourceManager.Fluent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;
using Fluent.Tests.Common;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Azure.Tests;
using Microsoft.Azure.Management.ResourceManager.Fluent.Models;
using System;

namespace Fluent.Tests.ResourceManager
{
    public class Providers
    {
        [Fact]
        public void CanRegisterAndUnRegisterProvider()
        {
            using (var context = FluentMockContext.Start(GetType().FullName))
            {
                var resourceManager = TestHelper.CreateResourceManager();
                var providers = resourceManager.Providers.List();
                IProvider provider = providers.FirstOrDefault(p=> p.Namespace.Equals("Microsoft.CognitiveServices", StringComparison.OrdinalIgnoreCase));
                Assert.NotNull(provider);

                provider = resourceManager.Providers.Unregister(provider.Namespace);
                while (provider.RegistrationState.Equals("Unregistering"))
                {
                    TestHelper.Delay(5000);
                    provider = resourceManager.Providers.GetByName(provider.Namespace);
                }

                provider = resourceManager.Providers.Register(provider.Namespace);
                while (provider.RegistrationState.Equals("Registering"))
                {
                    TestHelper.Delay(5000);
                    provider = resourceManager.Providers.GetByName(provider.Namespace);
                }
                Assert.Equal("Registered", provider.RegistrationState);
                IList<ProviderResourceTypeInner> resourceTypes = provider.ResourceTypes;
                Assert.True(resourceTypes.Count > 0);
            }
        }
    }
}
