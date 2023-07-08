// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct FixedAndActivityProjectType
    {
        private FixedAndActivityProjectType(string value)
        {
            this.Value = value;
        }

        public static FixedAndActivityProjectType ACTIVITY { get => new FixedAndActivityProjectType("ACTIVITY"); }
        public static FixedAndActivityProjectType CUSTOMIZED_FIXED { get => new FixedAndActivityProjectType("CUSTOMIZED_FIXED"); }

        public string Value { get; private set; }

        public static implicit operator string(FixedAndActivityProjectType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}