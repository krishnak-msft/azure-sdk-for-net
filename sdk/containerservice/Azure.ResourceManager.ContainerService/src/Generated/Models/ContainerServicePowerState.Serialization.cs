// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ContainerServicePowerState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ContainerServicePowerState DeserializeContainerServicePowerState(JsonElement element)
        {
            Optional<ContainerServiceStateCode> code = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    code = new ContainerServiceStateCode(property.Value.GetString());
                    continue;
                }
            }
            return new ContainerServicePowerState(Optional.ToNullable(code));
        }
    }
}
