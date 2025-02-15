// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ProviderPermission
    {
        internal static ProviderPermission DeserializeProviderPermission(JsonElement element)
        {
            Optional<string> applicationId = default;
            Optional<AzureRoleDefinition> roleDefinition = default;
            Optional<AzureRoleDefinition> managedByRoleDefinition = default;
            Optional<ProviderAuthorizationConsentState> providerAuthorizationConsentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    roleDefinition = AzureRoleDefinition.DeserializeAzureRoleDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("managedByRoleDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedByRoleDefinition = AzureRoleDefinition.DeserializeAzureRoleDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("providerAuthorizationConsentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    providerAuthorizationConsentState = new ProviderAuthorizationConsentState(property.Value.GetString());
                    continue;
                }
            }
            return new ProviderPermission(applicationId.Value, roleDefinition.Value, managedByRoleDefinition.Value, Optional.ToNullable(providerAuthorizationConsentState));
        }
    }
}
