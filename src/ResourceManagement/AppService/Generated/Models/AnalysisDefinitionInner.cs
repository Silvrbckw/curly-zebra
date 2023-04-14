// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of Analysis
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AnalysisDefinitionInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the AnalysisDefinitionInner class.
        /// </summary>
        public AnalysisDefinitionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnalysisDefinitionInner class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="description">Description of the Analysis</param>
        public AnalysisDefinitionInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), string description = default(string))
            : base(id, name, type, kind)
        {
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets description of the Analysis
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

    }
}
