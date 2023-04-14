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
    using System.Linq;

    /// <summary>
    /// Describes the gallery Image Definition purchase plan. This is used by
    /// marketplace images.
    /// </summary>
    public partial class ImagePurchasePlan
    {
        /// <summary>
        /// Initializes a new instance of the ImagePurchasePlan class.
        /// </summary>
        public ImagePurchasePlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImagePurchasePlan class.
        /// </summary>
        /// <param name="name">The plan ID.</param>
        /// <param name="publisher">The publisher ID.</param>
        /// <param name="product">The product ID.</param>
        public ImagePurchasePlan(string name = default(string), string publisher = default(string), string product = default(string))
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the product ID.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

    }
}
