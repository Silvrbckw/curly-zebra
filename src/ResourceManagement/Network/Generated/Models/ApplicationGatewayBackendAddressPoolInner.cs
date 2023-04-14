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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backend Address Pool of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayBackendAddressPoolInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendAddressPoolInner class.
        /// </summary>
        public ApplicationGatewayBackendAddressPoolInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendAddressPoolInner class.
        /// </summary>
        /// <param name="backendIPConfigurations">Collection of references to
        /// IPs defined in network interfaces.</param>
        /// <param name="backendAddresses">Backend addresses.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// backend address pool resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the backend address pool that is unique
        /// within an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayBackendAddressPoolInner(string id = default(string), IList<NetworkInterfaceIPConfigurationInner> backendIPConfigurations = default(IList<NetworkInterfaceIPConfigurationInner>), IList<ApplicationGatewayBackendAddress> backendAddresses = default(IList<ApplicationGatewayBackendAddress>), ProvisioningState provisioningState = default(ProvisioningState), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            BackendIPConfigurations = backendIPConfigurations;
            BackendAddresses = backendAddresses;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets collection of references to IPs defined in network interfaces.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIPConfigurations")]
        public IList<NetworkInterfaceIPConfigurationInner> BackendIPConfigurations { get; private set; }

        /// <summary>
        /// Gets or sets backend addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddresses")]
        public IList<ApplicationGatewayBackendAddress> BackendAddresses { get; set; }

        /// <summary>
        /// Gets the provisioning state of the backend address pool resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the backend address pool that is unique within
        /// an Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
