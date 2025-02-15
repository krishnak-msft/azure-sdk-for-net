// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    internal partial class EventImpactedResourceListResult
    {
        internal static EventImpactedResourceListResult DeserializeEventImpactedResourceListResult(JsonElement element)
        {
            IReadOnlyList<EventImpactedResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<EventImpactedResourceData> array = new List<EventImpactedResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventImpactedResourceData.DeserializeEventImpactedResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EventImpactedResourceListResult(value, nextLink.Value);
        }
    }
}
