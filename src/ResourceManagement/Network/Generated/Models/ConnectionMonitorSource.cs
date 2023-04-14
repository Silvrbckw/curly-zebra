// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the source of connection monitor.
    /// </summary>
    public partial class ConnectionMonitorSource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorSource class.
        /// </summary>
        public ConnectionMonitorSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorSource class.
        /// </summary>
        /// <param name="resourceId">The ID of the resource used as the source
        /// by connection monitor.</param>
        /// <param name="port">The source port used by connection
        /// monitor.</param>
        public ConnectionMonitorSource(string resourceId, int? port = default(int?))
        {
            ResourceId = resourceId;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the resource used as the source by
        /// connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the source port used by connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
        }
    }
}
