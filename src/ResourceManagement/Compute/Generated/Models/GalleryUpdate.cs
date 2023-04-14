// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the Shared Image Gallery that you want to
    /// update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryUpdate : UpdateResourceDefinitionInner
    {
        /// <summary>
        /// Initializes a new instance of the GalleryUpdate class.
        /// </summary>
        public GalleryUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="description">The description of this Shared Image
        /// Gallery resource. This property is updatable.</param>
        /// <param name="provisioningState">The current state of the
        /// gallery.</param>
        public GalleryUpdate(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), GalleryIdentifier identifier = default(GalleryIdentifier), ProvisioningState provisioningState = default(ProvisioningState))
            : base(id, name, type, tags)
        {
            Description = description;
            Identifier = identifier;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of this Shared Image Gallery resource.
        /// This property is updatable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.identifier")]
        public GalleryIdentifier Identifier { get; set; }

        /// <summary>
        /// Gets the current state of the gallery.
        /// </summary>
        /// <remarks>
        /// The provisioning state, which only appears in the response.
        /// Possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

    }
}