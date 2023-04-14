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
    /// A top level domain object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TopLevelDomainInner : ProxyOnlyResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the TopLevelDomainInner class.
        /// </summary>
        public TopLevelDomainInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopLevelDomainInner class.
        /// </summary>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="privacy">If &lt;code&gt;true&lt;/code&gt;, then the
        /// top level domain supports domain privacy; otherwise,
        /// &lt;code&gt;false&lt;/code&gt;.</param>
        public TopLevelDomainInner(string id = default(string), string name = default(string), string type = default(string), string kind = default(string), bool? privacy = default(bool?))
            : base(id, name, type, kind)
        {
            Privacy = privacy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;, then
        /// the top level domain supports domain privacy; otherwise,
        /// &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacy")]
        public bool? Privacy { get; set; }

    }
}