// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings for upgrading an agentpool
    /// </summary>
    public partial class AgentPoolUpgradeSettings
    {
        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeSettings class.
        /// </summary>
        public AgentPoolUpgradeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeSettings class.
        /// </summary>
        /// <param name="maxSurge">Count or percentage of additional nodes to
        /// be added during upgrade. If empty uses AKS default</param>
        public AgentPoolUpgradeSettings(string maxSurge = default(string))
        {
            MaxSurge = maxSurge;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets count or percentage of additional nodes to be added
        /// during upgrade. If empty uses AKS default
        /// </summary>
        [JsonProperty(PropertyName = "maxSurge")]
        public string MaxSurge { get; set; }

    }
}
