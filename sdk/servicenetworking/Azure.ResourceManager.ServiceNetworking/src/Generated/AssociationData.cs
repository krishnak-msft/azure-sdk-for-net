// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceNetworking.Models;

namespace Azure.ResourceManager.ServiceNetworking
{
    /// <summary>
    /// A class representing the Association data model.
    /// Association Subresource of Traffic Controller
    /// </summary>
    public partial class AssociationData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AssociationData. </summary>
        /// <param name="location"> The location. </param>
        public AssociationData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of AssociationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="associationType"> Association Type. </param>
        /// <param name="subnet"> Association Subnet. </param>
        /// <param name="provisioningState"> Provisioning State. </param>
        internal AssociationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AssociationType? associationType, WritableSubResource subnet, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            AssociationType = associationType;
            Subnet = subnet;
            ProvisioningState = provisioningState;
        }

        /// <summary> Association Type. </summary>
        public AssociationType? AssociationType { get; set; }
        /// <summary> Association Subnet. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Provisioning State. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
