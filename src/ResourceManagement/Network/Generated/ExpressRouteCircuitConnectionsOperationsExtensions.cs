// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRouteCircuitConnectionsOperations.
    /// </summary>
    public static partial class ExpressRouteCircuitConnectionsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnectionInner> GetAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnectionInner> CreateOrUpdateAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnectionInner expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteCircuitConnectionInner>> ListAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Express Route Circuit Connection from the specified
            /// express route circuit.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a Express Route Circuit Connection in the specified
            /// express route circuits.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='circuitName'>
            /// The name of the express route circuit.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the express route circuit connection.
            /// </param>
            /// <param name='expressRouteCircuitConnectionParameters'>
            /// Parameters supplied to the create or update express route circuit
            /// connection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExpressRouteCircuitConnectionInner> BeginCreateOrUpdateAsync(this IExpressRouteCircuitConnectionsOperations operations, string resourceGroupName, string circuitName, string peeringName, string connectionName, ExpressRouteCircuitConnectionInner expressRouteCircuitConnectionParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, circuitName, peeringName, connectionName, expressRouteCircuitConnectionParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all global reach connections associated with a private peering in an
            /// express route circuit.
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
            public static async Task<IPage<ExpressRouteCircuitConnectionInner>> ListNextAsync(this IExpressRouteCircuitConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
