// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationsOperations.
    /// </summary>
    public static partial class ApplicationsOperationsExtensions
    {
            /// <summary>
            /// Create a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// The parameters for creating an application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInner> CreateAsync(this IApplicationsOperations operations, ApplicationCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists applications by filter parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationInner>> ListAsync(this IApplicationsOperations operations, ODataQuery<ApplicationInner> odataQuery = default(ODataQuery<ApplicationInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get an application by object ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInner> GetAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to update an existing application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchAsync(this IApplicationsOperations operations, string applicationObjectId, ApplicationUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Directory objects that are owners of the application.
            /// </summary>
            /// <remarks>
            /// The owners are a set of non-admin users who are allowed to modify this
            /// object.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// The object ID of the application for which to get owners.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DirectoryObject>> ListOwnersAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOwnersWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add an owner to an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// The object ID of the application to which to add the owner.
            /// </param>
            /// <param name='parameters'>
            /// The URL of the owner object, such as
            /// https://graph.windows.net/0b1f9851-1bf0-433f-aec3-cb9272f093dc/directoryObjects/f260bbc4-c254-447b-94cf-293b5ec434dd.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddOwnerAsync(this IApplicationsOperations operations, string applicationObjectId, AddOwnerParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddOwnerWithHttpMessagesAsync(applicationObjectId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Remove a member from owners.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// The object ID of the application from which to remove the owner.
            /// </param>
            /// <param name='ownerObjectId'>
            /// Owner object id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveOwnerAsync(this IApplicationsOperations operations, string applicationObjectId, string ownerObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RemoveOwnerWithHttpMessagesAsync(applicationObjectId, ownerObjectId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<KeyCredential>> ListKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeyCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the keyCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='value'>
            /// A collection of KeyCredentials.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateKeyCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, IList<KeyCredential> value, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateKeyCredentialsWithHttpMessagesAsync(applicationObjectId, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Models.PasswordCredential>> ListPasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPasswordCredentialsWithHttpMessagesAsync(applicationObjectId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update passwordCredentials associated with an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationObjectId'>
            /// Application object ID.
            /// </param>
            /// <param name='value'>
            /// A collection of PasswordCredentials.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdatePasswordCredentialsAsync(this IApplicationsOperations operations, string applicationObjectId, IList<Models.PasswordCredential> value, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdatePasswordCredentialsWithHttpMessagesAsync(applicationObjectId, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets an object id for a given application id from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationID'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServicePrincipalObjectResultInner> GetServicePrincipalsIdByAppIdAsync(this IApplicationsOperations operations, string applicationID, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetServicePrincipalsIdByAppIdWithHttpMessagesAsync(applicationID, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of applications from the current tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextLink'>
            /// Next link for the list operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApplicationInner>> ListNextAsync(this IApplicationsOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Directory objects that are owners of the application.
            /// </summary>
            /// <remarks>
            /// The owners are a set of non-admin users who are allowed to modify this
            /// object.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DirectoryObject>> ListOwnersNextAsync(this IApplicationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOwnersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}