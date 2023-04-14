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
    /// Specifies information about the SSH public key.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SshPublicKeyUpdateResource : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the SshPublicKeyUpdateResource class.
        /// </summary>
        public SshPublicKeyUpdateResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshPublicKeyUpdateResource class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="publicKey">SSH public key used to authenticate to a
        /// virtual machine through ssh. If this property is not initially
        /// provided when the resource is created, the publicKey property will
        /// be populated when generateKeyPair is called. If the public key is
        /// provided upon resource creation, the provided public key needs to
        /// be at least 2048-bit and in ssh-rsa format.</param>
        public SshPublicKeyUpdateResource(IDictionary<string, string> tags = default(IDictionary<string, string>), string publicKey = default(string))
            : base(tags)
        {
            PublicKey = publicKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SSH public key used to authenticate to a virtual
        /// machine through ssh. If this property is not initially provided
        /// when the resource is created, the publicKey property will be
        /// populated when generateKeyPair is called. If the public key is
        /// provided upon resource creation, the provided public key needs to
        /// be at least 2048-bit and in ssh-rsa format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicKey")]
        public string PublicKey { get; set; }

    }
}
