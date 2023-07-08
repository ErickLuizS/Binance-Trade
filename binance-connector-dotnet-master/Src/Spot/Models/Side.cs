// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct Side
    {
        private Side(string value)
        {
            this.Value = value;
        }

        public static Side BUY { get => new Side("BUY"); }
        public static Side SELL { get => new Side("SELL"); }

        public string Value { get; private set; }

        public static implicit operator string(Side enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}