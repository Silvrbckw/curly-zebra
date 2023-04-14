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
    /// Information on the connectivity status.
    /// </summary>
    public partial class ConnectivityInformationInner
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityInformationInner
        /// class.
        /// </summary>
        public ConnectivityInformationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityInformationInner
        /// class.
        /// </summary>
        /// <param name="hops">List of hops between the source and the
        /// destination.</param>
        /// <param name="connectionStatus">The connection status. Possible
        /// values include: 'Unknown', 'Connected', 'Disconnected',
        /// 'Degraded'</param>
        /// <param name="avgLatencyInMs">Average latency in
        /// milliseconds.</param>
        /// <param name="minLatencyInMs">Minimum latency in
        /// milliseconds.</param>
        /// <param name="maxLatencyInMs">Maximum latency in
        /// milliseconds.</param>
        /// <param name="probesSent">Total number of probes sent.</param>
        /// <param name="probesFailed">Number of failed probes.</param>
        public ConnectivityInformationInner(IList<ConnectivityHop> hops = default(IList<ConnectivityHop>), ConnectionStatus connectionStatus = default(ConnectionStatus), int? avgLatencyInMs = default(int?), int? minLatencyInMs = default(int?), int? maxLatencyInMs = default(int?), int? probesSent = default(int?), int? probesFailed = default(int?))
        {
            Hops = hops;
            ConnectionStatus = connectionStatus;
            AvgLatencyInMs = avgLatencyInMs;
            MinLatencyInMs = minLatencyInMs;
            MaxLatencyInMs = maxLatencyInMs;
            ProbesSent = probesSent;
            ProbesFailed = probesFailed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of hops between the source and the destination.
        /// </summary>
        [JsonProperty(PropertyName = "hops")]
        public IList<ConnectivityHop> Hops { get; private set; }

        /// <summary>
        /// Gets the connection status. Possible values include: 'Unknown',
        /// 'Connected', 'Disconnected', 'Degraded'
        /// </summary>
        [JsonProperty(PropertyName = "connectionStatus")]
        public ConnectionStatus ConnectionStatus { get; private set; }

        /// <summary>
        /// Gets average latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "avgLatencyInMs")]
        public int? AvgLatencyInMs { get; private set; }

        /// <summary>
        /// Gets minimum latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "minLatencyInMs")]
        public int? MinLatencyInMs { get; private set; }

        /// <summary>
        /// Gets maximum latency in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "maxLatencyInMs")]
        public int? MaxLatencyInMs { get; private set; }

        /// <summary>
        /// Gets total number of probes sent.
        /// </summary>
        [JsonProperty(PropertyName = "probesSent")]
        public int? ProbesSent { get; private set; }

        /// <summary>
        /// Gets number of failed probes.
        /// </summary>
        [JsonProperty(PropertyName = "probesFailed")]
        public int? ProbesFailed { get; private set; }

    }
}