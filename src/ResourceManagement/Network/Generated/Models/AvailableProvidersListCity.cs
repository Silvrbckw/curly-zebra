// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// City or town details.
    /// </summary>
    public partial class AvailableProvidersListCity
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCity class.
        /// </summary>
        public AvailableProvidersListCity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListCity class.
        /// </summary>
        /// <param name="cityName">The city or town name.</param>
        /// <param name="providers">A list of Internet service
        /// providers.</param>
        public AvailableProvidersListCity(string cityName = default(string), IList<string> providers = default(IList<string>))
        {
            CityName = cityName;
            Providers = providers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the city or town name.
        /// </summary>
        [JsonProperty(PropertyName = "cityName")]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or sets a list of Internet service providers.
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<string> Providers { get; set; }

    }
}
