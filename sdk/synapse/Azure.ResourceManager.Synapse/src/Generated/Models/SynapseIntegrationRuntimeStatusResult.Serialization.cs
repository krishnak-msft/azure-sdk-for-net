// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseIntegrationRuntimeStatusResult
    {
        internal static SynapseIntegrationRuntimeStatusResult DeserializeSynapseIntegrationRuntimeStatusResult(JsonElement element)
        {
            Optional<string> name = default;
            SynapseIntegrationRuntimeStatus properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    properties = SynapseIntegrationRuntimeStatus.DeserializeSynapseIntegrationRuntimeStatus(property.Value);
                    continue;
                }
            }
            return new SynapseIntegrationRuntimeStatusResult(name.Value, properties);
        }
    }
}
