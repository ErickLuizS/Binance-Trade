// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct RedemptionType
    {
        private RedemptionType(string value)
        {
            this.Value = value;
        }

        public static RedemptionType FAST { get => new RedemptionType("FAST"); }
        public static RedemptionType NORMAL { get => new RedemptionType("NORMAL"); }

        public string Value { get; private set; }

        public static implicit operator string(RedemptionType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}