// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProximityPlacementGroupsOperations.
    /// </summary>
    public static partial class ProximityPlacementGroupsOperationsExtensions
    {
            /// <summary>
            /// Create or update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Proximity Placement Group operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroupInner> CreateOrUpdateAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, ProximityPlacementGroupInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='tags'>
            /// Resource tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroupInner> UpdateAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a proximity placement group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves information about a proximity placement group .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='proximityPlacementGroupName'>
            /// The name of the proximity placement group.
            /// </param>
            /// <param name='includeColocationStatus'>
            /// includeColocationStatus=true enables fetching the colocation status of all
            /// the resources in the proximity placement group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProximityPlacementGroupInner> GetAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, string proximityPlacementGroupName, string includeColocationStatus = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, proximityPlacementGroupName, includeColocationStatus, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroupInner>> ListBySubscriptionAsync(this IProximityPlacementGroupsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroupInner>> ListByResourceGroupAsync(this IProximityPlacementGroupsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroupInner>> ListBySubscriptionNextAsync(this IProximityPlacementGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all proximity placement groups in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProximityPlacementGroupInner>> ListByResourceGroupNextAsync(this IProximityPlacementGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
