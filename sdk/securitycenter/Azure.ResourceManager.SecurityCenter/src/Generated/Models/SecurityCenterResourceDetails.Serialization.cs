// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityCenterResourceDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityCenterResourceDetails DeserializeSecurityCenterResourceDetails(JsonElement element)
        {
            if (element.TryGetProperty("source", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Azure": return AzureResourceDetails.DeserializeAzureResourceDetails(element);
                    case "OnPremise": return OnPremiseResourceDetails.DeserializeOnPremiseResourceDetails(element);
                    case "OnPremiseSql": return OnPremiseSqlResourceDetails.DeserializeOnPremiseSqlResourceDetails(element);
                }
            }
            return UnknownResourceDetails.DeserializeUnknownResourceDetails(element);
        }
    }
}
