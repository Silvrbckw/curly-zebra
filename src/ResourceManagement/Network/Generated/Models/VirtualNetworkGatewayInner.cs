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
    /// A common class for general resource information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayInner class.
        /// </summary>
        public VirtualNetworkGatewayInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayInner class.
        /// </summary>
        /// <param name="ipConfigurations">IP configurations for virtual
        /// network gateway.</param>
        /// <param name="gatewayType">The type of this virtual network gateway.
        /// Possible values include: 'Vpn', 'ExpressRoute'</param>
        /// <param name="vpnType">The type of this virtual network gateway.
        /// Possible values include: 'PolicyBased', 'RouteBased'</param>
        /// <param name="vpnGatewayGeneration">The generation for this
        /// VirtualNetworkGateway. Must be None if gatewayType is not VPN.
        /// Possible values include: 'None', 'Generation1',
        /// 'Generation2'</param>
        /// <param name="enableBgp">Whether BGP is enabled for this virtual
        /// network gateway or not.</param>
        /// <param name="activeActive">ActiveActive flag.</param>
        /// <param name="gatewayDefaultSite">The reference of the
        /// LocalNetworkGateway resource which represents local network site
        /// having default routes. Assign Null value in case of removing
        /// existing default site setting.</param>
        /// <param name="sku">The reference of the VirtualNetworkGatewaySku
        /// resource which represents the SKU selected for Virtual network
        /// gateway.</param>
        /// <param name="vpnClientConfiguration">The reference of the
        /// VpnClientConfiguration resource which represents the P2S VpnClient
        /// configurations.</param>
        /// <param name="bgpSettings">Virtual network gateway's BGP speaker
        /// settings.</param>
        /// <param name="customRoutes">The reference of the address space
        /// resource which represents the custom routes address space specified
        /// by the customer for virtual network gateway and VpnClient.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// virtual network gateway resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual network gateway resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="enableDnsForwarding">Whether dns forwarding is enabled
        /// or not.</param>
        /// <param name="inboundDnsForwardingEndpoint">The IP address allocated
        /// by the gateway to which dns requests can be sent.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualNetworkGatewayInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<VirtualNetworkGatewayIPConfigurationInner> ipConfigurations = default(IList<VirtualNetworkGatewayIPConfigurationInner>), VirtualNetworkGatewayType gatewayType = default(VirtualNetworkGatewayType), VpnType vpnType = default(VpnType), VpnGatewayGeneration vpnGatewayGeneration = default(VpnGatewayGeneration), bool? enableBgp = default(bool?), bool? activeActive = default(bool?), Management.ResourceManager.Fluent.SubResource gatewayDefaultSite = default(Management.ResourceManager.Fluent.SubResource), VirtualNetworkGatewaySku sku = default(VirtualNetworkGatewaySku), VpnClientConfiguration vpnClientConfiguration = default(VpnClientConfiguration), BgpSettings bgpSettings = default(BgpSettings), AddressSpace customRoutes = default(AddressSpace), string resourceGuid = default(string), ProvisioningState provisioningState = default(ProvisioningState), bool? enableDnsForwarding = default(bool?), string inboundDnsForwardingEndpoint = default(string), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            IpConfigurations = ipConfigurations;
            GatewayType = gatewayType;
            VpnType = vpnType;
            VpnGatewayGeneration = vpnGatewayGeneration;
            EnableBgp = enableBgp;
            ActiveActive = activeActive;
            GatewayDefaultSite = gatewayDefaultSite;
            Sku = sku;
            VpnClientConfiguration = vpnClientConfiguration;
            BgpSettings = bgpSettings;
            CustomRoutes = customRoutes;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            EnableDnsForwarding = enableDnsForwarding;
            InboundDnsForwardingEndpoint = inboundDnsForwardingEndpoint;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP configurations for virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<VirtualNetworkGatewayIPConfigurationInner> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the type of this virtual network gateway. Possible
        /// values include: 'Vpn', 'ExpressRoute'
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayType")]
        public VirtualNetworkGatewayType GatewayType { get; set; }

        /// <summary>
        /// Gets or sets the type of this virtual network gateway. Possible
        /// values include: 'PolicyBased', 'RouteBased'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnType")]
        public VpnType VpnType { get; set; }

        /// <summary>
        /// Gets or sets the generation for this VirtualNetworkGateway. Must be
        /// None if gatewayType is not VPN. Possible values include: 'None',
        /// 'Generation1', 'Generation2'
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnGatewayGeneration")]
        public VpnGatewayGeneration VpnGatewayGeneration { get; set; }

        /// <summary>
        /// Gets or sets whether BGP is enabled for this virtual network
        /// gateway or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBgp")]
        public bool? EnableBgp { get; set; }

        /// <summary>
        /// Gets or sets activeActive flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeActive")]
        public bool? ActiveActive { get; set; }

        /// <summary>
        /// Gets or sets the reference of the LocalNetworkGateway resource
        /// which represents local network site having default routes. Assign
        /// Null value in case of removing existing default site setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayDefaultSite")]
        public Management.ResourceManager.Fluent.SubResource GatewayDefaultSite { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VirtualNetworkGatewaySku resource
        /// which represents the SKU selected for Virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public VirtualNetworkGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets or sets the reference of the VpnClientConfiguration resource
        /// which represents the P2S VpnClient configurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vpnClientConfiguration")]
        public VpnClientConfiguration VpnClientConfiguration { get; set; }

        /// <summary>
        /// Gets or sets virtual network gateway's BGP speaker settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets or sets the reference of the address space resource which
        /// represents the custom routes address space specified by the
        /// customer for virtual network gateway and VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customRoutes")]
        public AddressSpace CustomRoutes { get; set; }

        /// <summary>
        /// Gets the resource GUID property of the virtual network gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network gateway
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets whether dns forwarding is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableDnsForwarding")]
        public bool? EnableDnsForwarding { get; set; }

        /// <summary>
        /// Gets the IP address allocated by the gateway to which dns requests
        /// can be sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundDnsForwardingEndpoint")]
        public string InboundDnsForwardingEndpoint { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
