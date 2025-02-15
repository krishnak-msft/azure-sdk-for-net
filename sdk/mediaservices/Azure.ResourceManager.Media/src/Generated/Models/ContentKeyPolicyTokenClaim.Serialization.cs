// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyTokenClaim : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClaimType))
            {
                writer.WritePropertyName("claimType"u8);
                writer.WriteStringValue(ClaimType);
            }
            if (Optional.IsDefined(ClaimValue))
            {
                writer.WritePropertyName("claimValue"u8);
                writer.WriteStringValue(ClaimValue);
            }
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyTokenClaim DeserializeContentKeyPolicyTokenClaim(JsonElement element)
        {
            Optional<string> claimType = default;
            Optional<string> claimValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("claimType"u8))
                {
                    claimType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claimValue"u8))
                {
                    claimValue = property.Value.GetString();
                    continue;
                }
            }
            return new ContentKeyPolicyTokenClaim(claimType.Value, claimValue.Value);
        }
    }
}
