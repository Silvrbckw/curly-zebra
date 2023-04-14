// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
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
    /// Describes a virtual machine scale set virtual machine.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetVMInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMInner
        /// class.
        /// </summary>
        public VirtualMachineScaleSetVMInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMInner
        /// class.
        /// </summary>
        /// <param name="instanceId">The virtual machine instance ID.</param>
        /// <param name="sku">The virtual machine SKU.</param>
        /// <param name="latestModelApplied">Specifies whether the latest model
        /// has been applied to the virtual machine.</param>
        /// <param name="vmId">Azure VM unique ID.</param>
        /// <param name="instanceView">The virtual machine instance
        /// view.</param>
        /// <param name="hardwareProfile">Specifies the hardware settings for
        /// the virtual machine.</param>
        /// <param name="storageProfile">Specifies the storage settings for the
        /// virtual machine disks.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the virtual machine in the
        /// scale set. For instance: whether the virtual machine has the
        /// capability to support attaching managed data disks with
        /// UltraSSD_LRS storage account type.</param>
        /// <param name="osProfile">Specifies the operating system settings for
        /// the virtual machine.</param>
        /// <param name="securityProfile">Specifies the Security related
        /// profile settings for the virtual machine.</param>
        /// <param name="networkProfile">Specifies the network interfaces of
        /// the virtual machine.</param>
        /// <param name="networkProfileConfiguration">Specifies the network
        /// profile configuration of the virtual machine.</param>
        /// <param name="diagnosticsProfile">Specifies the boot diagnostic
        /// settings state. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2015-06-15.</param>
        /// <param name="availabilitySet">Specifies information about the
        /// availability set that the virtual machine should be assigned to.
        /// Virtual machines specified in the same availability set are
        /// allocated to different nodes to maximize availability. For more
        /// information about availability sets, see [Manage the availability
        /// of virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// &lt;br&gt;&lt;br&gt; For more information on Azure planned
        /// maintenance, see [Planned maintenance for virtual machines in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to
        /// availability set at creation time. An existing VM cannot be added
        /// to an availability set.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="licenseType">Specifies that the image or disk that is
        /// being used was licensed on-premises. This element is only used for
        /// images that contain the Windows Server operating system.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server
        /// &lt;br&gt;&lt;br&gt; If this element is included in a request for
        /// an update, the value must match the initial value. This value
        /// cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see
        /// [Azure Hybrid Use Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15</param>
        /// <param name="modelDefinitionApplied">Specifies whether the model
        /// applied to the virtual machine is the model of the virtual machine
        /// scale set or the customized model for the virtual machine.</param>
        /// <param name="protectionPolicy">Specifies the protection policy of
        /// the virtual machine.</param>
        /// <param name="plan">Specifies information about the marketplace
        /// image used to create the virtual machine. This element is only used
        /// for marketplace images. Before you can use a marketplace image from
        /// an API, you must enable the image for programmatic use.  In the
        /// Azure portal, find the marketplace image that you want to use and
        /// then click **Want to deploy programmatically, Get Started -&gt;**.
        /// Enter any required information and then click **Save**.</param>
        /// <param name="resources">The virtual machine child extension
        /// resources.</param>
        /// <param name="zones">The virtual machine zones.</param>
        public VirtualMachineScaleSetVMInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string instanceId = default(string), Sku sku = default(Sku), bool? latestModelApplied = default(bool?), string vmId = default(string), VirtualMachineScaleSetVMInstanceView instanceView = default(VirtualMachineScaleSetVMInstanceView), HardwareProfile hardwareProfile = default(HardwareProfile), StorageProfile storageProfile = default(StorageProfile), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), OSProfile osProfile = default(OSProfile), SecurityProfile securityProfile = default(SecurityProfile), NetworkProfile networkProfile = default(NetworkProfile), VirtualMachineScaleSetVMNetworkProfileConfiguration networkProfileConfiguration = default(VirtualMachineScaleSetVMNetworkProfileConfiguration), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), Management.ResourceManager.Fluent.SubResource availabilitySet = default(Management.ResourceManager.Fluent.SubResource), string provisioningState = default(string), string licenseType = default(string), string modelDefinitionApplied = default(string), VirtualMachineScaleSetVMProtectionPolicy protectionPolicy = default(VirtualMachineScaleSetVMProtectionPolicy), Plan plan = default(Plan), IList<VirtualMachineExtensionInner> resources = default(IList<VirtualMachineExtensionInner>), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            InstanceId = instanceId;
            Sku = sku;
            LatestModelApplied = latestModelApplied;
            VmId = vmId;
            InstanceView = instanceView;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OsProfile = osProfile;
            SecurityProfile = securityProfile;
            NetworkProfile = networkProfile;
            NetworkProfileConfiguration = networkProfileConfiguration;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            LicenseType = licenseType;
            ModelDefinitionApplied = modelDefinitionApplied;
            ProtectionPolicy = protectionPolicy;
            Plan = plan;
            Resources = resources;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual machine instance ID.
        /// </summary>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; private set; }

        /// <summary>
        /// Gets the virtual machine SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets specifies whether the latest model has been applied to the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestModelApplied")]
        public bool? LatestModelApplied { get; private set; }

        /// <summary>
        /// Gets azure VM unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets the virtual machine instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineScaleSetVMInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets specifies the hardware settings for the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the storage settings for the virtual machine
        /// disks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies additional capabilities enabled or disabled
        /// on the virtual machine in the scale set. For instance: whether the
        /// virtual machine has the capability to support attaching managed
        /// data disks with UltraSSD_LRS storage account type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets specifies the operating system settings for the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the Security related profile settings for
        /// the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.securityProfile")]
        public SecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the network interfaces of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies the network profile configuration of the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkProfileConfiguration")]
        public VirtualMachineScaleSetVMNetworkProfileConfiguration NetworkProfileConfiguration { get; set; }

        /// <summary>
        /// Gets or sets specifies the boot diagnostic settings state.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2015-06-15.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the availability set that
        /// the virtual machine should be assigned to. Virtual machines
        /// specified in the same availability set are allocated to different
        /// nodes to maximize availability. For more information about
        /// availability sets, see [Manage the availability of virtual
        /// machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For more information on Azure
        /// planned maintenance, see [Planned maintenance for virtual machines
        /// in
        /// Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Currently, a VM can only be
        /// added to availability set at creation time. An existing VM cannot
        /// be added to an availability set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySet")]
        public Management.ResourceManager.Fluent.SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. This element is only used for images that
        /// contain the Windows Server operating system.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Client
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Windows_Server
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; If this element is included in
        /// a request for an update, the value must match the initial value.
        /// This value cannot be updated. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;
        /// For more information, see [Azure Hybrid Use Benefit for Windows
        /// Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json)
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Minimum api-version:
        /// 2015-06-15
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets specifies whether the model applied to the virtual machine is
        /// the model of the virtual machine scale set or the customized model
        /// for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modelDefinitionApplied")]
        public string ModelDefinitionApplied { get; private set; }

        /// <summary>
        /// Gets or sets specifies the protection policy of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protectionPolicy")]
        public VirtualMachineScaleSetVMProtectionPolicy ProtectionPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the marketplace image used
        /// to create the virtual machine. This element is only used for
        /// marketplace images. Before you can use a marketplace image from an
        /// API, you must enable the image for programmatic use.  In the Azure
        /// portal, find the marketplace image that you want to use and then
        /// click **Want to deploy programmatically, Get Started -&amp;gt;**.
        /// Enter any required information and then click **Save**.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets the virtual machine child extension resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<VirtualMachineExtensionInner> Resources { get; private set; }

        /// <summary>
        /// Gets the virtual machine zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
            if (Resources != null)
            {
                foreach (var element in Resources)
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
