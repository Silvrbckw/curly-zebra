// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set network profile.
    /// </summary>
    public partial class VirtualMachineScaleSetNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkProfile class.
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetNetworkProfile class.
        /// </summary>
        /// <param name="healthProbe">A reference to a load balancer probe used
        /// to determine the health of an instance in the virtual machine scale
        /// set. The reference will be in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'.</param>
        /// <param name="networkInterfaceConfigurations">The list of network
        /// configurations.</param>
        public VirtualMachineScaleSetNetworkProfile(ApiEntityReference healthProbe = default(ApiEntityReference), IList<VirtualMachineScaleSetNetworkConfigurationInner> networkInterfaceConfigurations = default(IList<VirtualMachineScaleSetNetworkConfigurationInner>))
        {
            HealthProbe = healthProbe;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a reference to a load balancer probe used to determine
        /// the health of an instance in the virtual machine scale set. The
        /// reference will be in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'.
        /// </summary>
        [JsonProperty(PropertyName = "healthProbe")]
        public ApiEntityReference HealthProbe { get; set; }

        /// <summary>
        /// Gets or sets the list of network configurations.
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceConfigurations")]
        public IList<VirtualMachineScaleSetNetworkConfigurationInner> NetworkInterfaceConfigurations { get; set; }

    }
}
