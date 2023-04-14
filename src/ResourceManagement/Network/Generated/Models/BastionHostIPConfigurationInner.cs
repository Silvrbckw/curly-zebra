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
    /// IP configuration of an Bastion Host.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BastionHostIPConfigurationInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the BastionHostIPConfigurationInner
        /// class.
        /// </summary>
        public BastionHostIPConfigurationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BastionHostIPConfigurationInner
        /// class.
        /// </summary>
        /// <param name="subnet">Reference of the subnet resource.</param>
        /// <param name="publicIPAddress">Reference of the PublicIP
        /// resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// bastion host IP configuration resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="privateIPAllocationMethod">Private IP allocation
        /// method. Possible values include: 'Static', 'Dynamic'</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Ip configuration type.</param>
        public BastionHostIPConfigurationInner(Management.ResourceManager.Fluent.SubResource subnet, Management.ResourceManager.Fluent.SubResource publicIPAddress, string id = default(string), ProvisioningState provisioningState = default(ProvisioningState), IPAllocationMethod privateIPAllocationMethod = default(IPAllocationMethod), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
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
        /// Gets or sets reference of the subnet resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Management.ResourceManager.Fluent.SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets reference of the PublicIP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public Management.ResourceManager.Fluent.SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets the provisioning state of the bastion host IP configuration
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets private IP allocation method. Possible values include:
        /// 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public IPAllocationMethod PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
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
        /// Gets ip configuration type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Subnet == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subnet");
            }
            if (PublicIPAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublicIPAddress");
            }
        }
    }
}
