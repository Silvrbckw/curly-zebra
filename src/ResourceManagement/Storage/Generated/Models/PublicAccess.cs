// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PublicAccess.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublicAccess
    {
        [EnumMember(Value = "Container")]
        Container,
        [EnumMember(Value = "Blob")]
        Blob,
        [EnumMember(Value = "None")]
        None
    }
    internal static class PublicAccessEnumExtension
    {
        internal static string ToSerializedValue(this PublicAccess? value)
        {
            return value == null ? null : ((PublicAccess)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PublicAccess value)
        {
            switch( value )
            {
                case PublicAccess.Container:
                    return "Container";
                case PublicAccess.Blob:
                    return "Blob";
                case PublicAccess.None:
                    return "None";
            }
            return null;
        }

        internal static PublicAccess? ParsePublicAccess(this string value)
        {
            switch( value )
            {
                case "Container":
                    return PublicAccess.Container;
                case "Blob":
                    return PublicAccess.Blob;
                case "None":
                    return PublicAccess.None;
            }
            return null;
        }
    }
}
