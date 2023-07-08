// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct LiquidityOperation
    {
        private LiquidityOperation(string value)
        {
            this.Value = value;
        }

        public static LiquidityOperation ADD { get => new LiquidityOperation("ADD"); }
        public static LiquidityOperation REMOVE { get => new LiquidityOperation("REMOVE"); }

        public string Value { get; private set; }

        public static implicit operator string(LiquidityOperation enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}