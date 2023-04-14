// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for patching Azure Cosmos DB database account properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseAccountUpdateParameters
        /// class.
        /// </summary>
        public DatabaseAccountUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        /// <param name="consistencyPolicy">The consistency policy for the
        /// Cosmos DB account.</param>
        /// <param name="locations">An array that contains the georeplication
        /// locations enabled for the Cosmos DB account.</param>
        /// <param name="ipRangeFilter">Cosmos DB Firewall Support: This value
        /// specifies the set of IP addresses or IP address ranges in CIDR form
        /// to be included as the allowed list of client IPs for a given
        /// database account. IP addresses/ranges must be comma separated and
        /// must not contain any spaces.</param>
        /// <param name="isVirtualNetworkFilterEnabled">Flag to indicate
        /// whether to enable/disable Virtual Network ACL rules.</param>
        /// <param name="enableAutomaticFailover">Enables automatic failover of
        /// the write region in the rare event that the region is unavailable
        /// due to an outage. Automatic failover will result in a new write
        /// region for the account and is chosen based on the failover
        /// priorities configured for the account.</param>
        /// <param name="capabilities">List of Cosmos DB capabilities for the
        /// account</param>
        /// <param name="virtualNetworkRules">List of Virtual Network ACL rules
        /// configured for the Cosmos DB account.</param>
        /// <param name="enableMultipleWriteLocations">Enables the account to
        /// write in multiple locations</param>
        /// <param name="enableCassandraConnector">Enables the cassandra
        /// connector on the Cosmos DB C* account</param>
        /// <param name="connectorOffer">The cassandra connector offer type for
        /// the Cosmos DB database C* account. Possible values include:
        /// 'Small'</param>
        /// <param name="disableKeyBasedMetadataWriteAccess">Disable write
        /// operations on metadata resources (databases, containers,
        /// throughput) via account keys</param>
        /// <param name="keyVaultKeyUri">The URI of the key vault</param>
        public DatabaseAccountUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), ConsistencyPolicy consistencyPolicy = default(ConsistencyPolicy), IList<Location> locations = default(IList<Location>), string ipRangeFilter = default(string), bool? isVirtualNetworkFilterEnabled = default(bool?), bool? enableAutomaticFailover = default(bool?), IList<Capability> capabilities = default(IList<Capability>), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), bool? enableMultipleWriteLocations = default(bool?), bool? enableCassandraConnector = default(bool?), ConnectorOffer connectorOffer = default(ConnectorOffer), bool? disableKeyBasedMetadataWriteAccess = default(bool?), string keyVaultKeyUri = default(string))
        {
            Tags = tags;
            Location = location;
            ConsistencyPolicy = consistencyPolicy;
            Locations = locations;
            IpRangeFilter = ipRangeFilter;
            IsVirtualNetworkFilterEnabled = isVirtualNetworkFilterEnabled;
            EnableAutomaticFailover = enableAutomaticFailover;
            Capabilities = capabilities;
            VirtualNetworkRules = virtualNetworkRules;
            EnableMultipleWriteLocations = enableMultipleWriteLocations;
            EnableCassandraConnector = enableCassandraConnector;
            ConnectorOffer = connectorOffer;
            DisableKeyBasedMetadataWriteAccess = disableKeyBasedMetadataWriteAccess;
            KeyVaultKeyUri = keyVaultKeyUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource group to which the
        /// resource belongs.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the consistency policy for the Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consistencyPolicy")]
        public ConsistencyPolicy ConsistencyPolicy { get; set; }

        /// <summary>
        /// Gets or sets an array that contains the georeplication locations
        /// enabled for the Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.locations")]
        public IList<Location> Locations { get; set; }

        /// <summary>
        /// Gets or sets cosmos DB Firewall Support: This value specifies the
        /// set of IP addresses or IP address ranges in CIDR form to be
        /// included as the allowed list of client IPs for a given database
        /// account. IP addresses/ranges must be comma separated and must not
        /// contain any spaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipRangeFilter")]
        public string IpRangeFilter { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate whether to enable/disable Virtual
        /// Network ACL rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isVirtualNetworkFilterEnabled")]
        public bool? IsVirtualNetworkFilterEnabled { get; set; }

        /// <summary>
        /// Gets or sets enables automatic failover of the write region in the
        /// rare event that the region is unavailable due to an outage.
        /// Automatic failover will result in a new write region for the
        /// account and is chosen based on the failover priorities configured
        /// for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAutomaticFailover")]
        public bool? EnableAutomaticFailover { get; set; }

        /// <summary>
        /// Gets or sets list of Cosmos DB capabilities for the account
        /// </summary>
        [JsonProperty(PropertyName = "properties.capabilities")]
        public IList<Capability> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets list of Virtual Network ACL rules configured for the
        /// Cosmos DB account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets enables the account to write in multiple locations
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableMultipleWriteLocations")]
        public bool? EnableMultipleWriteLocations { get; set; }

        /// <summary>
        /// Gets or sets enables the cassandra connector on the Cosmos DB C*
        /// account
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableCassandraConnector")]
        public bool? EnableCassandraConnector { get; set; }

        /// <summary>
        /// Gets or sets the cassandra connector offer type for the Cosmos DB
        /// database C* account. Possible values include: 'Small'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorOffer")]
        public ConnectorOffer ConnectorOffer { get; set; }

        /// <summary>
        /// Gets or sets disable write operations on metadata resources
        /// (databases, containers, throughput) via account keys
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableKeyBasedMetadataWriteAccess")]
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }

        /// <summary>
        /// Gets or sets the URI of the key vault
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultKeyUri")]
        public string KeyVaultKeyUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConsistencyPolicy != null)
            {
                ConsistencyPolicy.Validate();
            }
            if (Locations != null)
            {
                foreach (var element in Locations)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}