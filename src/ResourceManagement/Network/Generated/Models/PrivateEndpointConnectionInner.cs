// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PrivateEndpointConnection resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpointConnectionInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnectionInner
        /// class.
        /// </summary>
        public PrivateEndpointConnectionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnectionInner
        /// class.
        /// </summary>
        /// <param name="privateEndpoint">The resource of private end
        /// point.</param>
        /// <param name="privateLinkServiceConnectionState">A collection of
        /// information about the state of the connection between service
        /// consumer and provider.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// private endpoint connection resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="linkIdentifier">The consumer link id.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public PrivateEndpointConnectionInner(string id = default(string), PrivateEndpointInner privateEndpoint = default(PrivateEndpointInner), PrivateLinkServiceConnectionState privateLinkServiceConnectionState = default(PrivateLinkServiceConnectionState), ProvisioningState provisioningState = default(ProvisioningState), string linkIdentifier = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
            Name = name;
            Type = type;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource of private end point.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpoint")]
        public PrivateEndpointInner PrivateEndpoint { get; private set; }

        /// <summary>
        /// Gets or sets a collection of information about the state of the
        /// connection between service consumer and provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Gets the provisioning state of the private endpoint connection
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the consumer link id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkIdentifier")]
        public string LinkIdentifier { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
