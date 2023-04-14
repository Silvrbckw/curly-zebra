// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request routing rule of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayRequestRoutingRuleInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRuleInner class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRuleInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRuleInner class.
        /// </summary>
        /// <param name="ruleType">Rule type. Possible values include: 'Basic',
        /// 'PathBasedRouting'</param>
        /// <param name="priority">Priority of the request routing
        /// rule.</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// the application gateway.</param>
        /// <param name="backendHttpSettings">Backend http settings resource of
        /// the application gateway.</param>
        /// <param name="httpListener">Http listener resource of the
        /// application gateway.</param>
        /// <param name="urlPathMap">URL path map resource of the application
        /// gateway.</param>
        /// <param name="rewriteRuleSet">Rewrite Rule Set resource in Basic
        /// rule of the application gateway.</param>
        /// <param name="redirectConfiguration">Redirect configuration resource
        /// of the application gateway.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// request routing rule resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the request routing rule that is unique
        /// within an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayRequestRoutingRuleInner(string id = default(string), ApplicationGatewayRequestRoutingRuleType ruleType = default(ApplicationGatewayRequestRoutingRuleType), int? priority = default(int?), Management.ResourceManager.Fluent.SubResource backendAddressPool = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource backendHttpSettings = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource httpListener = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource urlPathMap = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource rewriteRuleSet = default(Management.ResourceManager.Fluent.SubResource), Management.ResourceManager.Fluent.SubResource redirectConfiguration = default(Management.ResourceManager.Fluent.SubResource), ProvisioningState provisioningState = default(ProvisioningState), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            RuleType = ruleType;
            Priority = priority;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            RewriteRuleSet = rewriteRuleSet;
            RedirectConfiguration = redirectConfiguration;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rule type. Possible values include: 'Basic',
        /// 'PathBasedRouting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleType")]
        public ApplicationGatewayRequestRoutingRuleType RuleType { get; set; }

        /// <summary>
        /// Gets or sets priority of the request routing rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public Management.ResourceManager.Fluent.SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets backend http settings resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public Management.ResourceManager.Fluent.SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets http listener resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListener")]
        public Management.ResourceManager.Fluent.SubResource HttpListener { get; set; }

        /// <summary>
        /// Gets or sets URL path map resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMap")]
        public Management.ResourceManager.Fluent.SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Gets or sets rewrite Rule Set resource in Basic rule of the
        /// application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rewriteRuleSet")]
        public Management.ResourceManager.Fluent.SubResource RewriteRuleSet { get; set; }

        /// <summary>
        /// Gets or sets redirect configuration resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfiguration")]
        public Management.ResourceManager.Fluent.SubResource RedirectConfiguration { get; set; }

        /// <summary>
        /// Gets the provisioning state of the request routing rule resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the request routing rule that is unique within
        /// an Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Priority > 20000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 20000);
            }
            if (Priority < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 1);
            }
        }
    }
}
