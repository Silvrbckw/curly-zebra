// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Docker container settings.
    /// </summary>
    public partial class ContainerSettings
    {
        /// <summary>
        /// Initializes a new instance of the ContainerSettings class.
        /// </summary>
        public ContainerSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerSettings class.
        /// </summary>
        /// <param name="imageSourceRegistry">Image source registry.</param>
        /// <param name="shmSize">/dev/shm size.</param>
        public ContainerSettings(ImageSourceRegistry imageSourceRegistry, string shmSize = default(string))
        {
            ImageSourceRegistry = imageSourceRegistry;
            ShmSize = shmSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets image source registry.
        /// </summary>
        /// <remarks>
        /// Information about docker image and docker registry to download the
        /// container from.
        /// </remarks>
        [JsonProperty(PropertyName = "imageSourceRegistry")]
        public ImageSourceRegistry ImageSourceRegistry { get; set; }

        /// <summary>
        /// Gets or sets /dev/shm size.
        /// </summary>
        /// <remarks>
        /// Size of /dev/shm. Please refer to docker documentation for
        /// supported argument formats.
        /// </remarks>
        [JsonProperty(PropertyName = "shmSize")]
        public string ShmSize { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImageSourceRegistry == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ImageSourceRegistry");
            }
            if (ImageSourceRegistry != null)
            {
                ImageSourceRegistry.Validate();
            }
        }
    }
}