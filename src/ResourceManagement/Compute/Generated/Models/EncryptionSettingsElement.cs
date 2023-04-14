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
    /// Encryption settings for one disk volume.
    /// </summary>
    public partial class EncryptionSettingsElement
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionSettingsElement class.
        /// </summary>
        public EncryptionSettingsElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionSettingsElement class.
        /// </summary>
        /// <param name="diskEncryptionKey">Key Vault Secret Url and vault id
        /// of the disk encryption key</param>
        /// <param name="keyEncryptionKey">Key Vault Key Url and vault id of
        /// the key encryption key. KeyEncryptionKey is optional and when
        /// provided is used to unwrap the disk encryption key.</param>
        public EncryptionSettingsElement(KeyVaultAndSecretReference diskEncryptionKey = default(KeyVaultAndSecretReference), KeyVaultAndKeyReference keyEncryptionKey = default(KeyVaultAndKeyReference))
        {
            DiskEncryptionKey = diskEncryptionKey;
            KeyEncryptionKey = keyEncryptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key Vault Secret Url and vault id of the disk
        /// encryption key
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionKey")]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets key Vault Key Url and vault id of the key encryption
        /// key. KeyEncryptionKey is optional and when provided is used to
        /// unwrap the disk encryption key.
        /// </summary>
        [JsonProperty(PropertyName = "keyEncryptionKey")]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskEncryptionKey != null)
            {
                DiskEncryptionKey.Validate();
            }
            if (KeyEncryptionKey != null)
            {
                KeyEncryptionKey.Validate();
            }
        }
    }
}
