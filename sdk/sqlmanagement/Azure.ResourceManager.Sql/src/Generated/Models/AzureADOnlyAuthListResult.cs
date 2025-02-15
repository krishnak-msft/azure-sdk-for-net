// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of active directory only authentications. </summary>
    internal partial class AzureADOnlyAuthListResult
    {
        /// <summary> Initializes a new instance of AzureADOnlyAuthListResult. </summary>
        internal AzureADOnlyAuthListResult()
        {
            Value = new ChangeTrackingList<SqlServerAzureADOnlyAuthenticationData>();
        }

        /// <summary> Initializes a new instance of AzureADOnlyAuthListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal AzureADOnlyAuthListResult(IReadOnlyList<SqlServerAzureADOnlyAuthenticationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerAzureADOnlyAuthenticationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
