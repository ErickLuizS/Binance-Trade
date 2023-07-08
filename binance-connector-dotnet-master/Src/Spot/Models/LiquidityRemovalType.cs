// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct LiquidityRemovalType
    {
        private LiquidityRemovalType(string value)
        {
            this.Value = value;
        }

        public static LiquidityRemovalType SINGLE { get => new LiquidityRemovalType("SINGLE"); }
        public static LiquidityRemovalType COMBINATION { get => new LiquidityRemovalType("COMBINATION"); }

        public string Value { get; private set; }

        public static implicit operator string(LiquidityRemovalType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}