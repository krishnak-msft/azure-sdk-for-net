// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metadata about the resource. </summary>
    internal partial class Metadata
    {
        /// <summary> Initializes a new instance of Metadata. </summary>
        internal Metadata()
        {
        }

        /// <summary> Initializes a new instance of Metadata. </summary>
        /// <param name="provisionedBy"> Azure offering managing this resource on-behalf-of customer. </param>
        internal Metadata(string provisionedBy)
        {
            ProvisionedBy = provisionedBy;
        }

        /// <summary> Azure offering managing this resource on-behalf-of customer. </summary>
        public string ProvisionedBy { get; }
    }
}
