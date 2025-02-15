// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WeeklyRetentionSchedule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DaysOfTheWeek))
            {
                writer.WritePropertyName("daysOfTheWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfTheWeek)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RetentionTimes))
            {
                writer.WritePropertyName("retentionTimes"u8);
                writer.WriteStartArray();
                foreach (var item in RetentionTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionDuration))
            {
                writer.WritePropertyName("retentionDuration"u8);
                writer.WriteObjectValue(RetentionDuration);
            }
            writer.WriteEndObject();
        }

        internal static WeeklyRetentionSchedule DeserializeWeeklyRetentionSchedule(JsonElement element)
        {
            Optional<IList<BackupDayOfWeek>> daysOfTheWeek = default;
            Optional<IList<DateTimeOffset>> retentionTimes = default;
            Optional<RetentionDuration> retentionDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysOfTheWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BackupDayOfWeek> array = new List<BackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupDayOfWeek());
                    }
                    daysOfTheWeek = array;
                    continue;
                }
                if (property.NameEquals("retentionTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    retentionTimes = array;
                    continue;
                }
                if (property.NameEquals("retentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionDuration = RetentionDuration.DeserializeRetentionDuration(property.Value);
                    continue;
                }
            }
            return new WeeklyRetentionSchedule(Optional.ToList(daysOfTheWeek), Optional.ToList(retentionTimes), retentionDuration.Value);
        }
    }
}
