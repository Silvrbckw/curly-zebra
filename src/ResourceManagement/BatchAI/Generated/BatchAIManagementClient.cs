// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The Azure BatchAI Management API.
    /// </summary>
    public partial class BatchAIManagementClient : FluentServiceClientBase<BatchAIManagementClient>, IBatchAIManagementClient, IAzureClient
    {
        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }
        
        /// <summary>
        /// The subscriptionID for the Azure user.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Specifies the version of API used for this request.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        public virtual IUsagesOperations Usages { get; private set; }

        /// <summary>
        /// Gets the IWorkspacesOperations.
        /// </summary>
        public virtual IWorkspacesOperations Workspaces { get; private set; }

        /// <summary>
        /// Gets the IExperimentsOperations.
        /// </summary>
        public virtual IExperimentsOperations Experiments { get; private set; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        public virtual IJobsOperations Jobs { get; private set; }

        /// <summary>
        /// Gets the IFileServersOperations.
        /// </summary>
        public virtual IFileServersOperations FileServers { get; private set; }

        /// <summary>
        /// Gets the IClustersOperations.
        /// </summary>
        public virtual IClustersOperations Clusters { get; private set; }

        /// <summary>
        /// Initializes a new instance of the BatchAIManagementClient class.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public BatchAIManagementClient(RestClient restClient) 
            : base(restClient)
        {
        }

        private BatchAIManagementClient(RestClient restClient, System.Net.Http.HttpClient httpClient) : base(restClient, httpClient)
        {
        }

        public static BatchAIManagementClient NewInstance(RestClient restClient)
        {
            return restClient.HttpClient == null ? new BatchAIManagementClient(restClient) : new BatchAIManagementClient(restClient, restClient.HttpClient);
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        protected override void Initialize()
        {
            Operations = new Operations(this);
            Usages = new UsagesOperations(this);
            Workspaces = new WorkspacesOperations(this);
            Experiments = new ExperimentsOperations(this);
            Jobs = new JobsOperations(this);
            FileServers = new FileServersOperations(this);
            Clusters = new ClustersOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2018-05-01";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}