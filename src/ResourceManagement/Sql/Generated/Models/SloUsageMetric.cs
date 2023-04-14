// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Slo Usage Metric.
    /// </summary>
    public partial class SloUsageMetric
    {
        /// <summary>
        /// Initializes a new instance of the SloUsageMetric class.
        /// </summary>
        public SloUsageMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SloUsageMetric class.
        /// </summary>
        /// <param name="serviceLevelObjective">The serviceLevelObjective for
        /// SLO usage metric. Possible values include: 'System', 'System0',
        /// 'System1', 'System2', 'System3', 'System4', 'System2L', 'System3L',
        /// 'System4L', 'Free', 'Basic', 'S0', 'S1', 'S2', 'S3', 'S4', 'S6',
        /// 'S7', 'S9', 'S12', 'P1', 'P2', 'P3', 'P4', 'P6', 'P11', 'P15',
        /// 'PRS1', 'PRS2', 'PRS4', 'PRS6', 'DW100', 'DW200', 'DW300', 'DW400',
        /// 'DW500', 'DW600', 'DW1000', 'DW1200', 'DW1000c', 'DW1500',
        /// 'DW1500c', 'DW2000', 'DW2000c', 'DW3000', 'DW2500c', 'DW3000c',
        /// 'DW6000', 'DW5000c', 'DW6000c', 'DW7500c', 'DW10000c', 'DW15000c',
        /// 'DW30000c', 'DS100', 'DS200', 'DS300', 'DS400', 'DS500', 'DS600',
        /// 'DS1000', 'DS1200', 'DS1500', 'DS2000', 'ElasticPool'</param>
        /// <param name="serviceLevelObjectiveId">The serviceLevelObjectiveId
        /// for SLO usage metric.</param>
        /// <param name="inRangeTimeRatio">Gets or sets inRangeTimeRatio for
        /// SLO usage metric.</param>
        public SloUsageMetric(ServiceObjectiveName serviceLevelObjective = default(ServiceObjectiveName), System.Guid serviceLevelObjectiveId = default(System.Guid), double inRangeTimeRatio = default(double))
        {
            ServiceLevelObjective = serviceLevelObjective;
            ServiceLevelObjectiveId = serviceLevelObjectiveId;
            InRangeTimeRatio = inRangeTimeRatio;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the serviceLevelObjective for SLO usage metric. Possible
        /// values include: 'System', 'System0', 'System1', 'System2',
        /// 'System3', 'System4', 'System2L', 'System3L', 'System4L', 'Free',
        /// 'Basic', 'S0', 'S1', 'S2', 'S3', 'S4', 'S6', 'S7', 'S9', 'S12',
        /// 'P1', 'P2', 'P3', 'P4', 'P6', 'P11', 'P15', 'PRS1', 'PRS2', 'PRS4',
        /// 'PRS6', 'DW100', 'DW200', 'DW300', 'DW400', 'DW500', 'DW600',
        /// 'DW1000', 'DW1200', 'DW1000c', 'DW1500', 'DW1500c', 'DW2000',
        /// 'DW2000c', 'DW3000', 'DW2500c', 'DW3000c', 'DW6000', 'DW5000c',
        /// 'DW6000c', 'DW7500c', 'DW10000c', 'DW15000c', 'DW30000c', 'DS100',
        /// 'DS200', 'DS300', 'DS400', 'DS500', 'DS600', 'DS1000', 'DS1200',
        /// 'DS1500', 'DS2000', 'ElasticPool'
        /// </summary>
        [JsonProperty(PropertyName = "serviceLevelObjective")]
        public ServiceObjectiveName ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets the serviceLevelObjectiveId for SLO usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "serviceLevelObjectiveId")]
        public System.Guid ServiceLevelObjectiveId { get; private set; }

        /// <summary>
        /// Gets or sets inRangeTimeRatio for SLO usage metric.
        /// </summary>
        [JsonProperty(PropertyName = "inRangeTimeRatio")]
        public double InRangeTimeRatio { get; private set; }

    }
}
