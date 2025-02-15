// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class PrepareDataMoveContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetRegion"u8);
            writer.WriteStringValue(TargetRegion);
            writer.WritePropertyName("dataMoveLevel"u8);
            writer.WriteStringValue(DataMoveLevel.ToString());
            if (Optional.IsCollectionDefined(SourceContainerArmIds))
            {
                writer.WritePropertyName("sourceContainerArmIds"u8);
                writer.WriteStartArray();
                foreach (var item in SourceContainerArmIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IgnoreMoved))
            {
                writer.WritePropertyName("ignoreMoved"u8);
                writer.WriteBooleanValue(IgnoreMoved.Value);
            }
            writer.WriteEndObject();
        }
    }
}
