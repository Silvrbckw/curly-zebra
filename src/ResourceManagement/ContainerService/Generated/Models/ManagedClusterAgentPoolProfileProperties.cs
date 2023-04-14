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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the container service agent pool profile.
    /// </summary>
    public partial class ManagedClusterAgentPoolProfileProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAgentPoolProfileProperties class.
        /// </summary>
        public ManagedClusterAgentPoolProfileProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAgentPoolProfileProperties class.
        /// </summary>
        /// <param name="count">Number of agents (VMs) to host docker
        /// containers. Allowed values must be in the range of 0 to 100
        /// (inclusive) for user pools and in the range of 1 to 100 (inclusive)
        /// for system pools. The default value is 1.</param>
        /// <param name="vmSize">Size of agent VMs. Possible values include:
        /// 'Standard_A1', 'Standard_A10', 'Standard_A11', 'Standard_A1_v2',
        /// 'Standard_A2', 'Standard_A2_v2', 'Standard_A2m_v2', 'Standard_A3',
        /// 'Standard_A4', 'Standard_A4_v2', 'Standard_A4m_v2', 'Standard_A5',
        /// 'Standard_A6', 'Standard_A7', 'Standard_A8', 'Standard_A8_v2',
        /// 'Standard_A8m_v2', 'Standard_A9', 'Standard_B2ms', 'Standard_B2s',
        /// 'Standard_B4ms', 'Standard_B8ms', 'Standard_D1', 'Standard_D11',
        /// 'Standard_D11_v2', 'Standard_D11_v2_Promo', 'Standard_D12',
        /// 'Standard_D12_v2', 'Standard_D12_v2_Promo', 'Standard_D13',
        /// 'Standard_D13_v2', 'Standard_D13_v2_Promo', 'Standard_D14',
        /// 'Standard_D14_v2', 'Standard_D14_v2_Promo', 'Standard_D15_v2',
        /// 'Standard_D16_v3', 'Standard_D16s_v3', 'Standard_D1_v2',
        /// 'Standard_D2', 'Standard_D2_v2', 'Standard_D2_v2_Promo',
        /// 'Standard_D2_v3', 'Standard_D2s_v3', 'Standard_D3',
        /// 'Standard_D32_v3', 'Standard_D32s_v3', 'Standard_D3_v2',
        /// 'Standard_D3_v2_Promo', 'Standard_D4', 'Standard_D4_v2',
        /// 'Standard_D4_v2_Promo', 'Standard_D4_v3', 'Standard_D4s_v3',
        /// 'Standard_D5_v2', 'Standard_D5_v2_Promo', 'Standard_D64_v3',
        /// 'Standard_D64s_v3', 'Standard_D8_v3', 'Standard_D8s_v3',
        /// 'Standard_DS1', 'Standard_DS11', 'Standard_DS11_v2',
        /// 'Standard_DS11_v2_Promo', 'Standard_DS12', 'Standard_DS12_v2',
        /// 'Standard_DS12_v2_Promo', 'Standard_DS13', 'Standard_DS13-2_v2',
        /// 'Standard_DS13-4_v2', 'Standard_DS13_v2', 'Standard_DS13_v2_Promo',
        /// 'Standard_DS14', 'Standard_DS14-4_v2', 'Standard_DS14-8_v2',
        /// 'Standard_DS14_v2', 'Standard_DS14_v2_Promo', 'Standard_DS15_v2',
        /// 'Standard_DS1_v2', 'Standard_DS2', 'Standard_DS2_v2',
        /// 'Standard_DS2_v2_Promo', 'Standard_DS3', 'Standard_DS3_v2',
        /// 'Standard_DS3_v2_Promo', 'Standard_DS4', 'Standard_DS4_v2',
        /// 'Standard_DS4_v2_Promo', 'Standard_DS5_v2',
        /// 'Standard_DS5_v2_Promo', 'Standard_E16_v3', 'Standard_E16s_v3',
        /// 'Standard_E2_v3', 'Standard_E2s_v3', 'Standard_E32-16s_v3',
        /// 'Standard_E32-8s_v3', 'Standard_E32_v3', 'Standard_E32s_v3',
        /// 'Standard_E4_v3', 'Standard_E4s_v3', 'Standard_E64-16s_v3',
        /// 'Standard_E64-32s_v3', 'Standard_E64_v3', 'Standard_E64s_v3',
        /// 'Standard_E8_v3', 'Standard_E8s_v3', 'Standard_F1', 'Standard_F16',
        /// 'Standard_F16s', 'Standard_F16s_v2', 'Standard_F1s', 'Standard_F2',
        /// 'Standard_F2s', 'Standard_F2s_v2', 'Standard_F32s_v2',
        /// 'Standard_F4', 'Standard_F4s', 'Standard_F4s_v2',
        /// 'Standard_F64s_v2', 'Standard_F72s_v2', 'Standard_F8',
        /// 'Standard_F8s', 'Standard_F8s_v2', 'Standard_G1', 'Standard_G2',
        /// 'Standard_G3', 'Standard_G4', 'Standard_G5', 'Standard_GS1',
        /// 'Standard_GS2', 'Standard_GS3', 'Standard_GS4', 'Standard_GS4-4',
        /// 'Standard_GS4-8', 'Standard_GS5', 'Standard_GS5-16',
        /// 'Standard_GS5-8', 'Standard_H16', 'Standard_H16m',
        /// 'Standard_H16mr', 'Standard_H16r', 'Standard_H8', 'Standard_H8m',
        /// 'Standard_L16s', 'Standard_L32s', 'Standard_L4s', 'Standard_L8s',
        /// 'Standard_M128-32ms', 'Standard_M128-64ms', 'Standard_M128ms',
        /// 'Standard_M128s', 'Standard_M64-16ms', 'Standard_M64-32ms',
        /// 'Standard_M64ms', 'Standard_M64s', 'Standard_NC12',
        /// 'Standard_NC12s_v2', 'Standard_NC12s_v3', 'Standard_NC24',
        /// 'Standard_NC24r', 'Standard_NC24rs_v2', 'Standard_NC24rs_v3',
        /// 'Standard_NC24s_v2', 'Standard_NC24s_v3', 'Standard_NC6',
        /// 'Standard_NC6s_v2', 'Standard_NC6s_v3', 'Standard_ND12s',
        /// 'Standard_ND24rs', 'Standard_ND24s', 'Standard_ND6s',
        /// 'Standard_NV12', 'Standard_NV24', 'Standard_NV6'</param>
        /// <param name="osDiskSizeGB">OS Disk Size in GB to be used to specify
        /// the disk size for every machine in this master/agent pool. If you
        /// specify 0, it will apply the default osDisk size according to the
        /// vmSize specified.</param>
        /// <param name="osDiskType">OS disk type to be used for machines in a
        /// given agent pool. Allowed values are 'Ephemeral' and 'Managed'.
        /// Defaults to 'Managed'. May not be changed after creation. Possible
        /// values include: 'Managed', 'Ephemeral'</param>
        /// <param name="kubeletDiskType">KubeletDiskType determines the
        /// placement of emptyDir volumes, container runtime data root, and
        /// Kubelet ephemeral storage. Currently allows one value, OS,
        /// resulting in Kubelet using the OS disk for data. Possible values
        /// include: 'OS'</param>
        /// <param name="vnetSubnetID">VNet SubnetID specifies the VNet's
        /// subnet identifier for nodes and maybe pods</param>
        /// <param name="podSubnetID">Pod SubnetID specifies the VNet's subnet
        /// identifier for pods.</param>
        /// <param name="maxPods">Maximum number of pods that can run on a
        /// node.</param>
        /// <param name="osType">OsType to be used to specify os type. Choose
        /// from Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'</param>
        /// <param name="maxCount">Maximum number of nodes for
        /// auto-scaling</param>
        /// <param name="minCount">Minimum number of nodes for
        /// auto-scaling</param>
        /// <param name="enableAutoScaling">Whether to enable
        /// auto-scaler</param>
        /// <param name="type">AgentPoolType represents types of an agent pool.
        /// Possible values include: 'VirtualMachineScaleSets',
        /// 'AvailabilitySet'</param>
        /// <param name="mode">AgentPoolMode represents mode of an agent pool.
        /// Possible values include: 'System', 'User'</param>
        /// <param name="orchestratorVersion">Version of orchestrator specified
        /// when creating the managed cluster.</param>
        /// <param name="nodeImageVersion">Version of node image</param>
        /// <param name="upgradeSettings">Settings for upgrading the
        /// agentpool</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state, which only appears in the response.</param>
        /// <param name="powerState">Describes whether the Agent Pool is
        /// Running or Stopped</param>
        /// <param name="availabilityZones">Availability zones for nodes. Must
        /// use VirtualMachineScaleSets AgentPoolType.</param>
        /// <param name="enableNodePublicIP">Enable public IP for nodes</param>
        /// <param name="scaleSetPriority">ScaleSetPriority to be used to
        /// specify virtual machine scale set priority. Default to regular.
        /// Possible values include: 'Spot', 'Regular'</param>
        /// <param name="scaleSetEvictionPolicy">ScaleSetEvictionPolicy to be
        /// used to specify eviction policy for Spot virtual machine scale set.
        /// Default to Delete. Possible values include: 'Delete',
        /// 'Deallocate'</param>
        /// <param name="spotMaxPrice">SpotMaxPrice to be used to specify the
        /// maximum price you are willing to pay in US Dollars. Possible values
        /// are any decimal value greater than zero or -1 which indicates
        /// default price to be up-to on-demand.</param>
        /// <param name="tags">Agent pool tags to be persisted on the agent
        /// pool virtual machine scale set.</param>
        /// <param name="nodeLabels">Agent pool node labels to be persisted
        /// across all nodes in agent pool.</param>
        /// <param name="nodeTaints">Taints added to new nodes during node pool
        /// create and scale. For example, key=value:NoSchedule.</param>
        /// <param name="proximityPlacementGroupID">The ID for Proximity
        /// Placement Group.</param>
        /// <param name="kubeletConfig">KubeletConfig specifies the
        /// configuration of kubelet on agent nodes.</param>
        /// <param name="linuxOSConfig">LinuxOSConfig specifies the OS
        /// configuration of linux agent nodes.</param>
        /// <param name="enableEncryptionAtHost">Whether to enable
        /// EncryptionAtHost</param>
        public ManagedClusterAgentPoolProfileProperties(int? count = default(int?), ContainerServiceVMSizeTypes vmSize = default(ContainerServiceVMSizeTypes), int? osDiskSizeGB = default(int?), OSDiskType osDiskType = default(OSDiskType), KubeletDiskType kubeletDiskType = default(KubeletDiskType), string vnetSubnetID = default(string), string podSubnetID = default(string), int? maxPods = default(int?), OSType osType = default(OSType), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), AgentPoolType type = default(AgentPoolType), AgentPoolMode mode = default(AgentPoolMode), string orchestratorVersion = default(string), string nodeImageVersion = default(string), AgentPoolUpgradeSettings upgradeSettings = default(AgentPoolUpgradeSettings), string provisioningState = default(string), PowerState powerState = default(PowerState), IList<string> availabilityZones = default(IList<string>), bool? enableNodePublicIP = default(bool?), ScaleSetPriority scaleSetPriority = default(ScaleSetPriority), ScaleSetEvictionPolicy scaleSetEvictionPolicy = default(ScaleSetEvictionPolicy), double? spotMaxPrice = default(double?), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> nodeLabels = default(IDictionary<string, string>), IList<string> nodeTaints = default(IList<string>), string proximityPlacementGroupID = default(string), KubeletConfig kubeletConfig = default(KubeletConfig), LinuxOSConfig linuxOSConfig = default(LinuxOSConfig), bool? enableEncryptionAtHost = default(bool?))
        {
            Count = count;
            VmSize = vmSize;
            OsDiskSizeGB = osDiskSizeGB;
            OsDiskType = osDiskType;
            KubeletDiskType = kubeletDiskType;
            VnetSubnetID = vnetSubnetID;
            PodSubnetID = podSubnetID;
            MaxPods = maxPods;
            OsType = osType;
            MaxCount = maxCount;
            MinCount = minCount;
            EnableAutoScaling = enableAutoScaling;
            Type = type;
            Mode = mode;
            OrchestratorVersion = orchestratorVersion;
            NodeImageVersion = nodeImageVersion;
            UpgradeSettings = upgradeSettings;
            ProvisioningState = provisioningState;
            PowerState = powerState;
            AvailabilityZones = availabilityZones;
            EnableNodePublicIP = enableNodePublicIP;
            ScaleSetPriority = scaleSetPriority;
            ScaleSetEvictionPolicy = scaleSetEvictionPolicy;
            SpotMaxPrice = spotMaxPrice;
            Tags = tags;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            ProximityPlacementGroupID = proximityPlacementGroupID;
            KubeletConfig = kubeletConfig;
            LinuxOSConfig = linuxOSConfig;
            EnableEncryptionAtHost = enableEncryptionAtHost;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of agents (VMs) to host docker containers.
        /// Allowed values must be in the range of 0 to 100 (inclusive) for
        /// user pools and in the range of 1 to 100 (inclusive) for system
        /// pools. The default value is 1.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets size of agent VMs. Possible values include:
        /// 'Standard_A1', 'Standard_A10', 'Standard_A11', 'Standard_A1_v2',
        /// 'Standard_A2', 'Standard_A2_v2', 'Standard_A2m_v2', 'Standard_A3',
        /// 'Standard_A4', 'Standard_A4_v2', 'Standard_A4m_v2', 'Standard_A5',
        /// 'Standard_A6', 'Standard_A7', 'Standard_A8', 'Standard_A8_v2',
        /// 'Standard_A8m_v2', 'Standard_A9', 'Standard_B2ms', 'Standard_B2s',
        /// 'Standard_B4ms', 'Standard_B8ms', 'Standard_D1', 'Standard_D11',
        /// 'Standard_D11_v2', 'Standard_D11_v2_Promo', 'Standard_D12',
        /// 'Standard_D12_v2', 'Standard_D12_v2_Promo', 'Standard_D13',
        /// 'Standard_D13_v2', 'Standard_D13_v2_Promo', 'Standard_D14',
        /// 'Standard_D14_v2', 'Standard_D14_v2_Promo', 'Standard_D15_v2',
        /// 'Standard_D16_v3', 'Standard_D16s_v3', 'Standard_D1_v2',
        /// 'Standard_D2', 'Standard_D2_v2', 'Standard_D2_v2_Promo',
        /// 'Standard_D2_v3', 'Standard_D2s_v3', 'Standard_D3',
        /// 'Standard_D32_v3', 'Standard_D32s_v3', 'Standard_D3_v2',
        /// 'Standard_D3_v2_Promo', 'Standard_D4', 'Standard_D4_v2',
        /// 'Standard_D4_v2_Promo', 'Standard_D4_v3', 'Standard_D4s_v3',
        /// 'Standard_D5_v2', 'Standard_D5_v2_Promo', 'Standard_D64_v3',
        /// 'Standard_D64s_v3', 'Standard_D8_v3', 'Standard_D8s_v3',
        /// 'Standard_DS1', 'Standard_DS11', 'Standard_DS11_v2',
        /// 'Standard_DS11_v2_Promo', 'Standard_DS12', 'Standard_DS12_v2',
        /// 'Standard_DS12_v2_Promo', 'Standard_DS13', 'Standard_DS13-2_v2',
        /// 'Standard_DS13-4_v2', 'Standard_DS13_v2', 'Standard_DS13_v2_Promo',
        /// 'Standard_DS14', 'Standard_DS14-4_v2', 'Standard_DS14-8_v2',
        /// 'Standard_DS14_v2', 'Standard_DS14_v2_Promo', 'Standard_DS15_v2',
        /// 'Standard_DS1_v2', 'Standard_DS2', 'Standard_DS2_v2',
        /// 'Standard_DS2_v2_Promo', 'Standard_DS3', 'Standard_DS3_v2',
        /// 'Standard_DS3_v2_Promo', 'Standard_DS4', 'Standard_DS4_v2',
        /// 'Standard_DS4_v2_Promo', 'Standard_DS5_v2',
        /// 'Standard_DS5_v2_Promo', 'Standard_E16_v3', 'Standard_E16s_v3',
        /// 'Standard_E2_v3', 'Standard_E2s_v3', 'Standard_E32-16s_v3',
        /// 'Standard_E32-8s_v3', 'Standard_E32_v3', 'Standard_E32s_v3',
        /// 'Standard_E4_v3', 'Standard_E4s_v3', 'Standard_E64-16s_v3',
        /// 'Standard_E64-32s_v3', 'Standard_E64_v3', 'Standard_E64s_v3',
        /// 'Standard_E8_v3', 'Standard_E8s_v3', 'Standard_F1', 'Standard_F16',
        /// 'Standard_F16s', 'Standard_F16s_v2', 'Standard_F1s', 'Standard_F2',
        /// 'Standard_F2s', 'Standard_F2s_v2', 'Standard_F32s_v2',
        /// 'Standard_F4', 'Standard_F4s', 'Standard_F4s_v2',
        /// 'Standard_F64s_v2', 'Standard_F72s_v2', 'Standard_F8',
        /// 'Standard_F8s', 'Standard_F8s_v2', 'Standard_G1', 'Standard_G2',
        /// 'Standard_G3', 'Standard_G4', 'Standard_G5', 'Standard_GS1',
        /// 'Standard_GS2', 'Standard_GS3', 'Standard_GS4', 'Standard_GS4-4',
        /// 'Standard_GS4-8', 'Standard_GS5', 'Standard_GS5-16',
        /// 'Standard_GS5-8', 'Standard_H16', 'Standard_H16m',
        /// 'Standard_H16mr', 'Standard_H16r', 'Standard_H8', 'Standard_H8m',
        /// 'Standard_L16s', 'Standard_L32s', 'Standard_L4s', 'Standard_L8s',
        /// 'Standard_M128-32ms', 'Standard_M128-64ms', 'Standard_M128ms',
        /// 'Standard_M128s', 'Standard_M64-16ms', 'Standard_M64-32ms',
        /// 'Standard_M64ms', 'Standard_M64s', 'Standard_NC12',
        /// 'Standard_NC12s_v2', 'Standard_NC12s_v3', 'Standard_NC24',
        /// 'Standard_NC24r', 'Standard_NC24rs_v2', 'Standard_NC24rs_v3',
        /// 'Standard_NC24s_v2', 'Standard_NC24s_v3', 'Standard_NC6',
        /// 'Standard_NC6s_v2', 'Standard_NC6s_v3', 'Standard_ND12s',
        /// 'Standard_ND24rs', 'Standard_ND24s', 'Standard_ND6s',
        /// 'Standard_NV12', 'Standard_NV24', 'Standard_NV6'
        /// </summary>
        [JsonProperty(PropertyName = "vmSize")]
        public ContainerServiceVMSizeTypes VmSize { get; set; }

        /// <summary>
        /// Gets or sets OS Disk Size in GB to be used to specify the disk size
        /// for every machine in this master/agent pool. If you specify 0, it
        /// will apply the default osDisk size according to the vmSize
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "osDiskSizeGB")]
        public int? OsDiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets OS disk type to be used for machines in a given agent
        /// pool. Allowed values are 'Ephemeral' and 'Managed'. Defaults to
        /// 'Managed'. May not be changed after creation. Possible values
        /// include: 'Managed', 'Ephemeral'
        /// </summary>
        [JsonProperty(PropertyName = "osDiskType")]
        public OSDiskType OsDiskType { get; set; }

        /// <summary>
        /// Gets or sets kubeletDiskType determines the placement of emptyDir
        /// volumes, container runtime data root, and Kubelet ephemeral
        /// storage. Currently allows one value, OS, resulting in Kubelet using
        /// the OS disk for data. Possible values include: 'OS'
        /// </summary>
        [JsonProperty(PropertyName = "kubeletDiskType")]
        public KubeletDiskType KubeletDiskType { get; set; }

        /// <summary>
        /// Gets or sets vNet SubnetID specifies the VNet's subnet identifier
        /// for nodes and maybe pods
        /// </summary>
        [JsonProperty(PropertyName = "vnetSubnetID")]
        public string VnetSubnetID { get; set; }

        /// <summary>
        /// Gets or sets pod SubnetID specifies the VNet's subnet identifier
        /// for pods.
        /// </summary>
        [JsonProperty(PropertyName = "podSubnetID")]
        public string PodSubnetID { get; set; }

        /// <summary>
        /// Gets or sets maximum number of pods that can run on a node.
        /// </summary>
        [JsonProperty(PropertyName = "maxPods")]
        public int? MaxPods { get; set; }

        /// <summary>
        /// Gets or sets osType to be used to specify os type. Choose from
        /// Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OSType OsType { get; set; }

        /// <summary>
        /// Gets or sets maximum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "maxCount")]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Gets or sets minimum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "minCount")]
        public int? MinCount { get; set; }

        /// <summary>
        /// Gets or sets whether to enable auto-scaler
        /// </summary>
        [JsonProperty(PropertyName = "enableAutoScaling")]
        public bool? EnableAutoScaling { get; set; }

        /// <summary>
        /// Gets or sets agentPoolType represents types of an agent pool.
        /// Possible values include: 'VirtualMachineScaleSets',
        /// 'AvailabilitySet'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AgentPoolType Type { get; set; }

        /// <summary>
        /// Gets or sets agentPoolMode represents mode of an agent pool.
        /// Possible values include: 'System', 'User'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public AgentPoolMode Mode { get; set; }

        /// <summary>
        /// Gets or sets version of orchestrator specified when creating the
        /// managed cluster.
        /// </summary>
        [JsonProperty(PropertyName = "orchestratorVersion")]
        public string OrchestratorVersion { get; set; }

        /// <summary>
        /// Gets version of node image
        /// </summary>
        [JsonProperty(PropertyName = "nodeImageVersion")]
        public string NodeImageVersion { get; private set; }

        /// <summary>
        /// Gets or sets settings for upgrading the agentpool
        /// </summary>
        [JsonProperty(PropertyName = "upgradeSettings")]
        public AgentPoolUpgradeSettings UpgradeSettings { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets describes whether the Agent Pool is Running or Stopped
        /// </summary>
        [JsonProperty(PropertyName = "powerState")]
        public PowerState PowerState { get; private set; }

        /// <summary>
        /// Gets or sets availability zones for nodes. Must use
        /// VirtualMachineScaleSets AgentPoolType.
        /// </summary>
        [JsonProperty(PropertyName = "availabilityZones")]
        public IList<string> AvailabilityZones { get; set; }

        /// <summary>
        /// Gets or sets enable public IP for nodes
        /// </summary>
        [JsonProperty(PropertyName = "enableNodePublicIP")]
        public bool? EnableNodePublicIP { get; set; }

        /// <summary>
        /// Gets or sets scaleSetPriority to be used to specify virtual machine
        /// scale set priority. Default to regular. Possible values include:
        /// 'Spot', 'Regular'
        /// </summary>
        [JsonProperty(PropertyName = "scaleSetPriority")]
        public ScaleSetPriority ScaleSetPriority { get; set; }

        /// <summary>
        /// Gets or sets scaleSetEvictionPolicy to be used to specify eviction
        /// policy for Spot virtual machine scale set. Default to Delete.
        /// Possible values include: 'Delete', 'Deallocate'
        /// </summary>
        [JsonProperty(PropertyName = "scaleSetEvictionPolicy")]
        public ScaleSetEvictionPolicy ScaleSetEvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets spotMaxPrice to be used to specify the maximum price
        /// you are willing to pay in US Dollars. Possible values are any
        /// decimal value greater than zero or -1 which indicates default price
        /// to be up-to on-demand.
        /// </summary>
        [JsonProperty(PropertyName = "spotMaxPrice")]
        public double? SpotMaxPrice { get; set; }

        /// <summary>
        /// Gets or sets agent pool tags to be persisted on the agent pool
        /// virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets agent pool node labels to be persisted across all
        /// nodes in agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "nodeLabels")]
        public IDictionary<string, string> NodeLabels { get; set; }

        /// <summary>
        /// Gets or sets taints added to new nodes during node pool create and
        /// scale. For example, key=value:NoSchedule.
        /// </summary>
        [JsonProperty(PropertyName = "nodeTaints")]
        public IList<string> NodeTaints { get; set; }

        /// <summary>
        /// Gets or sets the ID for Proximity Placement Group.
        /// </summary>
        [JsonProperty(PropertyName = "proximityPlacementGroupID")]
        public string ProximityPlacementGroupID { get; set; }

        /// <summary>
        /// Gets or sets kubeletConfig specifies the configuration of kubelet
        /// on agent nodes.
        /// </summary>
        [JsonProperty(PropertyName = "kubeletConfig")]
        public KubeletConfig KubeletConfig { get; set; }

        /// <summary>
        /// Gets or sets linuxOSConfig specifies the OS configuration of linux
        /// agent nodes.
        /// </summary>
        [JsonProperty(PropertyName = "linuxOSConfig")]
        public LinuxOSConfig LinuxOSConfig { get; set; }

        /// <summary>
        /// Gets or sets whether to enable EncryptionAtHost
        /// </summary>
        [JsonProperty(PropertyName = "enableEncryptionAtHost")]
        public bool? EnableEncryptionAtHost { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KubeletConfig != null)
            {
                KubeletConfig.Validate();
            }
        }
    }
}
