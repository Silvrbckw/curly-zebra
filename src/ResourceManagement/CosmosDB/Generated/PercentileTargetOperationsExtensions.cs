// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PercentileTargetOperations.
    /// </summary>
    public static partial class PercentileTargetOperationsExtensions
    {
            /// <summary>
            /// Retrieves the metrics determined by the given filter for the given account
            /// target region. This url is only for PBS and Replication Latency data
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure resource group.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='targetRegion'>
            /// Target region to which data is written. Cosmos DB region, with spaces
            /// between words and each word capitalized.
            /// </param>
            /// <param name='filter'>
            /// An OData filter expression that describes a subset of metrics to return.
            /// The parameters that can be filtered are name.value (name of the metric, can
            /// have an or of multiple names), startTime, endTime, and timeGrain. The
            /// supported operator is eq.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PercentileMetric>> ListMetricsAsync(this IPercentileTargetOperations operations, string resourceGroupName, string accountName, string targetRegion, string filter, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListMetricsWithHttpMessagesAsync(resourceGroupName, accountName, targetRegion, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
