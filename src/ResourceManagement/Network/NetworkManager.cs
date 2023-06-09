﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using ResourceManager.Fluent.Core;
    using System;
    using System.Linq;
    using ResourceManager.Fluent.Authentication;
    /// <summary>
    /// Entry point to Azure networking management.
    /// </summary>
    public class NetworkManager : Manager<INetworkManagementClient>, INetworkManager
    {
        private PublicIPAddressesImpl publicIPAddresses;
        private NetworkInterfacesImpl networkInterfaces;
        private NetworkSecurityGroupsImpl networkSecurityGroups;
        private NetworksImpl networks;
        private LoadBalancersImpl loadBalancers;
        private ApplicationGatewaysImpl appGateways;
        private IRouteTables routeTables;
        private NetworkWatchersImpl networkWatchers;
        private VirtualNetworkGatewaysImpl virtualNetworkGateways;
        private LocalNetworkGatewaysImpl localNetworkGateways;
        private ExpressRouteCircuitsImpl expressRouteCircuits;
        private ApplicationSecurityGroupsImpl applicationSecurityGroups;
        private RouteFiltersImpl routeFilters;
        private DdosProtectionPlansImpl ddosProtectionPlans;
        private PrivateLinkServicesImpl privateLinkServices;
        private AzureFirewallsImpl azureFirewalls;

        private NetworkManager(RestClient restClient, string subscriptionId) :
            base(restClient, subscriptionId, NetworkManagementClient.NewInstance(restClient))
        {
            Inner.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Creates an instance of NetworkManager that exposes storage resource management API entry points.
        /// </summary>
        /// <param name="credentials">the credentials to use</param>
        /// <param name="subscriptionId">the subscription UUID</param>
        /// <returns>the NetworkManager</returns>
        public static INetworkManager Authenticate(AzureCredentials credentials, string subscriptionId)
        {
            return new NetworkManager(RestClient.Configure()
                    .WithEnvironment(credentials.Environment)
                    .WithCredentials(credentials)
                    .WithDelegatingHandler(new ProviderRegistrationDelegatingHandler(credentials))
                    .Build(), subscriptionId);
        }

        /// <summary>
        /// Creates an instance of NetworkManager that exposes storage resource management API entry points.
        /// </summary>
        /// <param name="restClient">the RestClient to be used for API calls.</param>
        /// <param name="subscriptionId">the subscription UUID</param>
        /// <returns>the NetworkManager</returns>
        public static INetworkManager Authenticate(RestClient restClient, string subscriptionId)
        {
            return new NetworkManager(restClient, subscriptionId);
        }

        /// <summary>
        /// Get a Configurable instance that can be used to create NetworkManager with optional configuration.
        /// </summary>
        /// <returns>the instance allowing configurations</returns>
        public static IConfigurable Configure()
        {
            return new Configurable();
        }

        /// <summary>
        /// The inteface allowing configurations to be set.
        /// </summary>
        public interface IConfigurable : IAzureConfigurable<IConfigurable>
        {
            INetworkManager Authenticate(AzureCredentials credentials, string subscriptionId);
        }

        protected class Configurable :
            AzureConfigurable<IConfigurable>,
            IConfigurable
        {
            /// <summary>
            /// Creates an instance of NetworkManager that exposes storage management API entry points.
            /// </summary>
            /// <param name="credentials">credentials the credentials to use</param>
            /// <param name="subscriptionId">The subscription UUID</param>
            /// <return>the interface exposing storage management API entry points that work in a subscription</returns>
            public INetworkManager Authenticate(AzureCredentials credentials, string subscriptionId)
            {
                return new NetworkManager(BuildRestClient(credentials), subscriptionId);
            }
        }

        /// <summary>
        /// return entry point to virtual network management
        /// </summary>
        public INetworks Networks
        {
            get
            {
                if (networks == null)
                {
                    networks = new NetworksImpl(this);
                }

                return networks;
            }
        }

        /// <summary>
        /// return entry point to network security group management
        /// </summary>
        public INetworkSecurityGroups NetworkSecurityGroups
        {
            get
            {
                if (networkSecurityGroups == null)
                {
                    networkSecurityGroups = new NetworkSecurityGroupsImpl(this);
                }

                return networkSecurityGroups;
            }
        }

        /// <summary>
        /// return entry point to public IP address management
        /// </summary>
        public IPublicIPAddresses PublicIPAddresses
        {
            get
            {
                if (publicIPAddresses == null)
                {
                    publicIPAddresses = new PublicIPAddressesImpl(this);
                }

                return publicIPAddresses;
            }
        }

        /// <summary>
        /// Entry point to network interface management.
        /// </summary>
        public INetworkInterfaces NetworkInterfaces
        {
            get
            {
                if (networkInterfaces == null)
                {
                    networkInterfaces = new NetworkInterfacesImpl(this);
                }

                return networkInterfaces;
            }
        }

        /// <summary>
        /// Entry point to application gateway management.
        /// </summary>
        public IApplicationGateways ApplicationGateways
        {
            get
            {
                if (appGateways == null)
                {
                    appGateways = new ApplicationGatewaysImpl(this);
                }

                return appGateways;
            }
        }

        /// <summary>
        /// returns entry point to load balancer management
        /// </summary>
        public ILoadBalancers LoadBalancers
        {
            get
            {
                if (loadBalancers == null)
                {
                    loadBalancers = new LoadBalancersImpl(this);
                }

                return loadBalancers;
            }
        }

        /// <summary>
        /// return entry point to route table management
        /// </summary>
        public IRouteTables RouteTables
        {
            get
            {
                if (routeTables == null)
                {
                    routeTables = new RouteTablesImpl(this);
                }

                return routeTables;
            }
        }

        /// <summary>
        /// return entry point to network watchers management
        /// </summary>
        public INetworkWatchers NetworkWatchers
        {
            get
            {
                if (networkWatchers == null)
                {
                    networkWatchers = new NetworkWatchersImpl(this);
                }

                return networkWatchers;
            }
        }

        /// <summary>
        /// return entry point to virtual network gateways management
        /// </summary>
        public IVirtualNetworkGateways VirtualNetworkGateways
        {
            get
            {
                if (virtualNetworkGateways == null)
                {
                    virtualNetworkGateways = new VirtualNetworkGatewaysImpl(this);
                }

                return virtualNetworkGateways;
            }
        }

        /// <summary>
        /// return entry point to local network gateways management
        /// </summary>
        public ILocalNetworkGateways LocalNetworkGateways
        {
            get
            {
                if (localNetworkGateways == null)
                {
                    localNetworkGateways = new LocalNetworkGatewaysImpl(this);
                }

                return localNetworkGateways;
            }
        }

        /// <summary>
        /// return entry point to express route circuits management
        /// </summary>
        public IExpressRouteCircuits ExpressRouteCircuits
        {
            get
            {
                if (expressRouteCircuits == null)
                {
                    expressRouteCircuits = new ExpressRouteCircuitsImpl(this);
                }

                return expressRouteCircuits;
            }
        }

        /// <summary>
        /// return entry point to application security groups management
        /// </summary>
        public IApplicationSecurityGroups ApplicationSecurityGroups
        {
            get
            {
                if (applicationSecurityGroups == null)
                {
                    applicationSecurityGroups = new ApplicationSecurityGroupsImpl(this);
                }

                return applicationSecurityGroups;
            }
        }

        /// <summary>
        /// return entry point to route filters management
        /// </summary>
        public IRouteFilters RouteFilters
        {
            get
            {
                if (routeFilters == null)
                {
                    routeFilters = new RouteFiltersImpl(this);
                }

                return routeFilters;
            }
        }

        /// <summary>
        /// return entry point to DDoD protection plans management
        /// </summary>
        public IDdosProtectionPlans DdosProtectionPlans
        {
            get
            {
                if (ddosProtectionPlans == null)
                {
                    ddosProtectionPlans = new DdosProtectionPlansImpl(this);
                }

                return ddosProtectionPlans;
            }
        }

        /// <summary>
        /// returns entry point to private link services management
        /// </summary>
        public IPrivateLinkServices PrivateLinkServices
        {
            get
            {
                if (privateLinkServices == null)
                {
                    privateLinkServices = new PrivateLinkServicesImpl(this);
                }

                return privateLinkServices;
            }
        }

        /// <summary>
        /// returns entry point to Azure firewalls management
        /// </summary>
        public IAzureFirewalls AzureFirewalls
        {
            get
            {
                if (azureFirewalls == null)
                {
                    azureFirewalls = new AzureFirewallsImpl(this);
                }

                return azureFirewalls;
            }
        }
    }

    public interface INetworkManagerBeta : IBeta
    {
        /// <summary>
        /// return entry point to network watchers management
        /// </summary>
        INetworkWatchers NetworkWatchers { get; }

        /// <summary>
        /// return entry point to virtual network gateways management
        /// </summary>
        IVirtualNetworkGateways VirtualNetworkGateways { get; }

        /// <summary>
        /// return entry point to local network gateways management
        /// </summary>
        ILocalNetworkGateways LocalNetworkGateways { get; }

        /// <summary>
        /// return entry point to express route circuits management
        /// </summary>
        IExpressRouteCircuits ExpressRouteCircuits { get; }

        /// <summary>
        /// return entry point to application security groups management
        /// </summary>
        IApplicationSecurityGroups ApplicationSecurityGroups { get; }

        /// <summary>
        /// return entry point to route filters management
        /// </summary>
        IRouteFilters RouteFilters { get; }

        /// <summary>
        /// return entry point to DDoS protection plans management
        /// </summary>
        IDdosProtectionPlans DdosProtectionPlans { get; }
    }

    public interface INetworkManager : INetworkManagerBeta, IManager<INetworkManagementClient>
    {
        /// <summary>
        /// Entry point to application gateway management.
        /// </summary>
        IApplicationGateways ApplicationGateways { get; }

        /// <summary>
        /// return entry point to load balancer management
        /// </summary>
        ILoadBalancers LoadBalancers { get; }

        /// <summary>
        /// return entry point to virtual network management
        /// </summary>
        INetworks Networks { get; }

        /// <summary>
        /// return entry point to network security group management
        /// </summary>
        INetworkSecurityGroups NetworkSecurityGroups { get; }

        /// <summary>
        /// return entry point to public IP address management
        /// </summary>
        IPublicIPAddresses PublicIPAddresses { get; }

        /// <summary>
        /// return entry point to network interface management
        /// </summary>
        INetworkInterfaces NetworkInterfaces { get; }

        /// <summary>
        /// Entry point to route table management
        /// </summary>
        IRouteTables RouteTables { get; }

        /// <summary>
        /// Entry point to private link service management
        /// </summary>
        IPrivateLinkServices PrivateLinkServices { get; }

        /// <summary>
        /// Entry point to Azure firewall management
        /// </summary>
        IAzureFirewalls AzureFirewalls { get; }
    }
}
