// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Information of user assigned identity used by this add-on.
    /// </summary>
    public partial class ManagedClusterAddonProfileIdentity : UserAssignedIdentity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAddonProfileIdentity class.
        /// </summary>
        public ManagedClusterAddonProfileIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAddonProfileIdentity class.
        /// </summary>
        /// <param name="resourceId">The resource id of the user assigned
        /// identity.</param>
        /// <param name="clientId">The client id of the user assigned
        /// identity.</param>
        /// <param name="objectId">The object id of the user assigned
        /// identity.</param>
        public ManagedClusterAddonProfileIdentity(string resourceId = default(string), string clientId = default(string), string objectId = default(string))
            : base(resourceId, clientId, objectId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
