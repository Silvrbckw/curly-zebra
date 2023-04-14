// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for IpsecIntegrity.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<IpsecIntegrity>))]
    public class IpsecIntegrity : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<IpsecIntegrity>
    {
        public static readonly IpsecIntegrity MD5 = Parse("MD5");
        public static readonly IpsecIntegrity SHA1 = Parse("SHA1");
        public static readonly IpsecIntegrity SHA256 = Parse("SHA256");
        public static readonly IpsecIntegrity GCMAES128 = Parse("GCMAES128");
        public static readonly IpsecIntegrity GCMAES192 = Parse("GCMAES192");
        public static readonly IpsecIntegrity GCMAES256 = Parse("GCMAES256");
    }
}
