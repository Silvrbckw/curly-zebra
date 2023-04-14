// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The service objectives capability.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceObjectiveCapability
    {
        /// <summary>
        /// Initializes a new instance of the ServiceObjectiveCapability class.
        /// </summary>
        public ServiceObjectiveCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceObjectiveCapability class.
        /// </summary>
        /// <param name="name">The service objective name.</param>
        /// <param name="status">The status of the service objective. Possible
        /// values include: 'Visible', 'Available', 'Default',
        /// 'Disabled'</param>
        /// <param name="unit">Unit type used to measure service objective
        /// performance level. Possible values include: 'DTU'</param>
        /// <param name="value">Performance level value.</param>
        /// <param name="id">The unique ID of the service objective.</param>
        /// <param name="supportedMaxSizes">The list of supported maximum
        /// database sizes for this service objective.</param>
        /// <param name="includedMaxSize">The included (free) max size for this
        /// service level objective.</param>
        public ServiceObjectiveCapability(string name = default(string), CapabilityStatus? status = default(CapabilityStatus?), PerformanceLevelUnit? unit = default(PerformanceLevelUnit?), int? value = default(int?), System.Guid id = default(System.Guid), IList<MaxSizeCapability> supportedMaxSizes = default(IList<MaxSizeCapability>), MaxSizeCapability includedMaxSize = default(MaxSizeCapability))
        {
            Name = name;
            Status = status;
            Unit = unit;
            Value = value;
            Id = id;
            SupportedMaxSizes = supportedMaxSizes;
            IncludedMaxSize = includedMaxSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the service objective name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the status of the service objective. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets unit type used to measure service objective performance level.
        /// Possible values include: 'DTU'
        /// </summary>
        [JsonProperty(PropertyName = "performanceLevel.unit")]
        public PerformanceLevelUnit? Unit { get; private set; }

        /// <summary>
        /// Gets performance level value.
        /// </summary>
        [JsonProperty(PropertyName = "performanceLevel.value")]
        public int? Value { get; private set; }

        /// <summary>
        /// Gets the unique ID of the service objective.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets the list of supported maximum database sizes for this service
        /// objective.
        /// </summary>
        [JsonProperty(PropertyName = "supportedMaxSizes")]
        public IList<MaxSizeCapability> SupportedMaxSizes { get; private set; }

        /// <summary>
        /// Gets the included (free) max size for this service level objective.
        /// </summary>
        [JsonProperty(PropertyName = "includedMaxSize")]
        public MaxSizeCapability IncludedMaxSize { get; private set; }

    }
}
