// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct LendingType
    {
        private LendingType(string value)
        {
            this.Value = value;
        }

        public static LendingType DAILY { get => new LendingType("DAILY"); }
        public static LendingType ACTIVITY { get => new LendingType("ACTIVITY"); }
        public static LendingType CUSTOMIZED_FIXED { get => new LendingType("CUSTOMIZED_FIXED"); }

        public string Value { get; private set; }

        public static implicit operator string(LendingType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}