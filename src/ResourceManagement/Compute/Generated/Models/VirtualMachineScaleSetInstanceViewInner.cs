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
    /// The instance view of a virtual machine scale set.
    /// </summary>
    public partial class VirtualMachineScaleSetInstanceViewInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetInstanceViewInner class.
        /// </summary>
        public VirtualMachineScaleSetInstanceViewInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetInstanceViewInner class.
        /// </summary>
        /// <param name="virtualMachine">The instance view status summary for
        /// the virtual machine scale set.</param>
        /// <param name="extensions">The extensions information.</param>
        /// <param name="statuses">The resource status information.</param>
        /// <param name="orchestrationServices">The orchestration services
        /// information.</param>
        public VirtualMachineScaleSetInstanceViewInner(VirtualMachineScaleSetInstanceViewStatusesSummary virtualMachine = default(VirtualMachineScaleSetInstanceViewStatusesSummary), IList<VirtualMachineScaleSetVMExtensionsSummary> extensions = default(IList<VirtualMachineScaleSetVMExtensionsSummary>), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>), IList<OrchestrationServiceSummary> orchestrationServices = default(IList<OrchestrationServiceSummary>))
        {
            VirtualMachine = virtualMachine;
            Extensions = extensions;
            Statuses = statuses;
            OrchestrationServices = orchestrationServices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the instance view status summary for the virtual machine scale
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachine")]
        public VirtualMachineScaleSetInstanceViewStatusesSummary VirtualMachine { get; private set; }

        /// <summary>
        /// Gets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineScaleSetVMExtensionsSummary> Extensions { get; private set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

        /// <summary>
        /// Gets the orchestration services information.
        /// </summary>
        [JsonProperty(PropertyName = "orchestrationServices")]
        public IList<OrchestrationServiceSummary> OrchestrationServices { get; private set; }

    }
}