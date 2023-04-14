// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ExpressionEvaluationOptionsScopeType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Fluent.Core.ExpandableStringEnumConverter<ExpressionEvaluationOptionsScopeType>))]
    public class ExpressionEvaluationOptionsScopeType : Fluent.Core.ExpandableStringEnum<ExpressionEvaluationOptionsScopeType>
    {
        public static readonly ExpressionEvaluationOptionsScopeType NotSpecified = Parse("NotSpecified");
        public static readonly ExpressionEvaluationOptionsScopeType Outer = Parse("Outer");
        public static readonly ExpressionEvaluationOptionsScopeType Inner = Parse("Inner");
    }
}