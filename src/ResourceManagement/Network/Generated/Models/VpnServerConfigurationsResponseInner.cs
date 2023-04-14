// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnServerConfigurations list associated with VirtualWan Response.
    /// </summary>
    public partial class VpnServerConfigurationsResponseInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VpnServerConfigurationsResponseInner class.
        /// </summary>
        public VpnServerConfigurationsResponseInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VpnServerConfigurationsResponseInner class.
        /// </summary>
        /// <param name="vpnServerConfigurationResourceIds">List of
        /// VpnServerConfigurations associated with VirtualWan.</param>
        public VpnServerConfigurationsResponseInner(IList<string> vpnServerConfigurationResourceIds = default(IList<string>))
        {
            VpnServerConfigurationResourceIds = vpnServerConfigurationResourceIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of VpnServerConfigurations associated with
        /// VirtualWan.
        /// </summary>
        [JsonProperty(PropertyName = "vpnServerConfigurationResourceIds")]
        public IList<string> VpnServerConfigurationResourceIds { get; set; }

    }
}
