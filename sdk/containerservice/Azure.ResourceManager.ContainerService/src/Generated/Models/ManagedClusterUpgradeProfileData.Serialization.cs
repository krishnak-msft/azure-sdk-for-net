// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class ManagedClusterUpgradeProfileData
    {
        internal static ManagedClusterUpgradeProfileData DeserializeManagedClusterUpgradeProfileData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            ManagedClusterPoolUpgradeProfile controlPlaneProfile = default;
            IReadOnlyList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("controlPlaneProfile"u8))
                        {
                            controlPlaneProfile = ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("agentPoolProfiles"u8))
                        {
                            List<ManagedClusterPoolUpgradeProfile> array = new List<ManagedClusterPoolUpgradeProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedClusterPoolUpgradeProfile.DeserializeManagedClusterPoolUpgradeProfile(item));
                            }
                            agentPoolProfiles = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedClusterUpgradeProfileData(id, name, type, systemData.Value, controlPlaneProfile, agentPoolProfiles);
        }
    }
}
