// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The encryption type of the VM. </summary>
    public readonly partial struct VmEncryptionType : IEquatable<VmEncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmEncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmEncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotEncryptedValue = "NotEncrypted";
        private const string OnePassEncryptedValue = "OnePassEncrypted";
        private const string TwoPassEncryptedValue = "TwoPassEncrypted";

        /// <summary> NotEncrypted. </summary>
        public static VmEncryptionType NotEncrypted { get; } = new VmEncryptionType(NotEncryptedValue);
        /// <summary> OnePassEncrypted. </summary>
        public static VmEncryptionType OnePassEncrypted { get; } = new VmEncryptionType(OnePassEncryptedValue);
        /// <summary> TwoPassEncrypted. </summary>
        public static VmEncryptionType TwoPassEncrypted { get; } = new VmEncryptionType(TwoPassEncryptedValue);
        /// <summary> Determines if two <see cref="VmEncryptionType"/> values are the same. </summary>
        public static bool operator ==(VmEncryptionType left, VmEncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmEncryptionType"/> values are not the same. </summary>
        public static bool operator !=(VmEncryptionType left, VmEncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VmEncryptionType"/>. </summary>
        public static implicit operator VmEncryptionType(string value) => new VmEncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmEncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmEncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
