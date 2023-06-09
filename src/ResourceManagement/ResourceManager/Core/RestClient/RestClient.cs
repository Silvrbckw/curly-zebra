﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Rest;
using Microsoft.Rest.TransientFaultHandling;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Core
{
    /// <summary>
    /// The RestClient
    /// </summary>
    public class RestClient
    {
        private List<DelegatingHandler> handlers;

        private RestClient(HttpClientHandler httpClientHandler, List<DelegatingHandler> handlers)
        {
            RootHttpHandler = httpClientHandler;
            this.handlers = handlers;
        }

        public AzureEnvironment Environment
        {
            get; private set;
        }

        public string BaseUri
        {
            get; private set;
        }

        public AzureCredentials Credentials
        {
            get; private set;
        }

        public RetryPolicy RetryPolicy
        {
            get; private set;
        }

        public IReadOnlyCollection<DelegatingHandler> Handlers
        {
            get
            {
                return new ReadOnlyCollection<DelegatingHandler>(handlers);
            }
        }

        public HttpClientHandler RootHttpHandler
        {
            get; private set;
        }

        public HttpClient HttpClient
        {
            get; private set;
        }

        /// <summary>
        /// Builder to configure and build a RestClient.
        /// </summary>
        /// <returns></returns>
        public static RestClientBuilder.IBlank Configure()
        {
            return new RestClientBuilder();
        }

        // The builder for <RestClient cref="RestClient" />
        public class RestClientBuilder : RestClientBuilder.IBlank, RestClientBuilder.IBuildable
        {
            private string baseUri;
            private AzureCredentials credentials;
            private List<DelegatingHandler> handlers;
            private RetryPolicy retryPolicy;
            private HttpLoggingDelegatingHandler loggingDelegatingHandler;
            private UserAgentDelegatingHandler userAgentDelegatingHandler;
            private HttpClient httpClient;

            /// <summary>
            /// Restrict access so that for users it can be created only by <HttpClient cref="RestClient.Configure" />
            /// </summary>
            internal RestClientBuilder()
            {
                handlers = new List<DelegatingHandler>();
                WithUserAgent("MacAddressHash", HashMACAddress(GetMACAddress()));
            }

            private string GetMACAddress()
            {
                try
                {
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    String sMacAddress = string.Empty;
                    foreach (NetworkInterface adapter in nics)
                    {
                        if (sMacAddress == String.Empty) // only return MAC Address from first card
                        {
                            IPInterfaceProperties properties = adapter.GetIPProperties();
                            sMacAddress = adapter.GetPhysicalAddress().ToString();
                        }
                    }
                    return sMacAddress;
                }
                catch
                {
                }
                return null;
            }

            private string HashMACAddress(string macAddress)
            {
                try
                {
                    var hashInput = Encoding.UTF8.GetBytes(macAddress);
                    return BitConverter.ToString(SHA256.Create().ComputeHash(hashInput)).Replace("-", string.Empty).ToLowerInvariant();
                }
                catch
                {
                }
                return "[Unavailable]";
            }
            
            public interface IBlank : IWithBaseUri, IWithEnvironment
            {
            }

            public interface IWithBaseUri
            {
                IBuildable WithBaseUri(string baseUri);
            }

            public interface IWithEnvironment
            {
                IBuildable WithEnvironment(AzureEnvironment environment);
            }

            public interface IBuildable : IWithEnvironment, IWithBaseUri
            {
                IBuildable WithUserAgent(string product, string version);

                IBuildable WithRetryPolicy(RetryPolicy retryPolicy);

                IBuildable WithDelegatingHandler(DelegatingHandler delegatingHandler);

                IBuildable WithDelegatingHandlers(params DelegatingHandler[] delegatingHandlers);

                IBuildable WithLogLevel(HttpLoggingDelegatingHandler.Level level);

                IBuildable WithCredentials(AzureCredentials credentials);

                IBuildable WithHttpClient(HttpClient httpClient);

                RestClient Build();
            }
            
            public IBuildable WithBaseUri(string baseUri)
            {
                this.baseUri = baseUri;
                return this;
            }

            public IBuildable WithEnvironment(AzureEnvironment environment)
            {
                this.environment = environment;
                return WithBaseUri(environment.ResourceManagerEndpoint);
            }

            public IBuildable WithUserAgent(string product, string version)
            {
                if (userAgentDelegatingHandler == null)
                {
                    userAgentDelegatingHandler = new UserAgentDelegatingHandler();
                    WithDelegatingHandler(userAgentDelegatingHandler);
                }
                userAgentDelegatingHandler.AppendUserAgent(product + "/" + version);
                return this;
            }

            public IBuildable WithDelegatingHandler(DelegatingHandler delegatingHandler)
            {
                handlers.Add(delegatingHandler);
                return this;
            }

            public IBuildable WithDelegatingHandlers(params DelegatingHandler[] delegatingHandlers)
            {
                handlers.AddRange(delegatingHandlers);
                return this;
            }

            public IBuildable WithRetryPolicy(RetryPolicy retryPolicy)
            {
                this.retryPolicy = retryPolicy;
                return this;
            }

            public IBuildable WithLogLevel(HttpLoggingDelegatingHandler.Level level)
            {
                if (loggingDelegatingHandler == null)
                {
                    loggingDelegatingHandler = new HttpLoggingDelegatingHandler();
                    WithDelegatingHandler(loggingDelegatingHandler);
                }
                loggingDelegatingHandler.LogLevel = level;
                return this;
            }

            public IBuildable WithCredentials(AzureCredentials credentials)
            {
                this.credentials = credentials;
                return this;
            }

            public IBuildable WithHttpClient(HttpClient httpClient)
            {
                this.httpClient = httpClient;
                return this;
            }

            public RestClient Build()
            {
                HttpClientHandler httpClientHandler = new HttpClientHandler();

                return new RestClient(httpClientHandler, handlers)
                {
                    BaseUri = baseUri,
                    Credentials = credentials,
                    RetryPolicy = retryPolicy,
                    Environment = this.Environment,
                    HttpClient = this.httpClient
                };
            }

            private AzureEnvironment environment;
            private AzureEnvironment Environment
            {
                get
                {
                    if (environment != null)
                    {
                        if (this.environment.ResourceManagerEndpoint != null)
                        {
                            var matchedEnvironment = AzureEnvironment
                                .KnownEnvironments
                                .FirstOrDefault(env => env.ResourceManagerEndpoint.StartsWith(this.environment.ResourceManagerEndpoint, StringComparison.OrdinalIgnoreCase));
                            if (matchedEnvironment != null)
                            {
                                if (environment.AuthenticationEndpoint == null)
                                {
                                    environment.AuthenticationEndpoint = matchedEnvironment.AuthenticationEndpoint;
                                }
                                if (environment.GraphEndpoint == null)
                                {
                                    environment.GraphEndpoint = matchedEnvironment.GraphEndpoint;
                                }
                                if (environment.ManagementEndpoint == null)
                                {
                                    environment.ManagementEndpoint = matchedEnvironment.ManagementEndpoint;
                                }
                                if (environment.StorageEndpointSuffix == null)
                                {
                                    environment.StorageEndpointSuffix = matchedEnvironment.StorageEndpointSuffix;
                                }
                            }
                        }
                    }
                    else if (baseUri != null)
                    {
                        environment = AzureEnvironment.KnownEnvironments.FirstOrDefault(env => env.ResourceManagerEndpoint.StartsWith(this.baseUri, StringComparison.OrdinalIgnoreCase));
                    }
                    return environment;
                }
            }
        }
    }
}