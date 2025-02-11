// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RegulatoryComplianceStandardsOperations
    /// </summary>
    public static partial class RegulatoryComplianceStandardsOperationsExtensions
    {
        /// <summary>
        /// Supported regulatory compliance standards details and state
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='filter'>
        /// OData filter. Optional.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RegulatoryComplianceStandard> List(this IRegulatoryComplianceStandardsOperations operations, string filter = default(string))
        {
                return ((IRegulatoryComplianceStandardsOperations)operations).ListAsync(filter).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Supported regulatory compliance standards details and state
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='filter'>
        /// OData filter. Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RegulatoryComplianceStandard>> ListAsync(this IRegulatoryComplianceStandardsOperations operations, string filter = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(filter, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='regulatoryComplianceStandardName'>
        /// Name of the regulatory compliance standard object
        /// </param>
        public static RegulatoryComplianceStandard Get(this IRegulatoryComplianceStandardsOperations operations, string regulatoryComplianceStandardName)
        {
                return ((IRegulatoryComplianceStandardsOperations)operations).GetAsync(regulatoryComplianceStandardName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Supported regulatory compliance details state for selected standard
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='regulatoryComplianceStandardName'>
        /// Name of the regulatory compliance standard object
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<RegulatoryComplianceStandard> GetAsync(this IRegulatoryComplianceStandardsOperations operations, string regulatoryComplianceStandardName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(regulatoryComplianceStandardName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Supported regulatory compliance standards details and state
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<RegulatoryComplianceStandard> ListNext(this IRegulatoryComplianceStandardsOperations operations, string nextPageLink)
        {
                return ((IRegulatoryComplianceStandardsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Supported regulatory compliance standards details and state
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<RegulatoryComplianceStandard>> ListNextAsync(this IRegulatoryComplianceStandardsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
