// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct TimeInForce
    {
        private TimeInForce(string value)
        {
            this.Value = value;
        }

        public static TimeInForce GTC { get => new TimeInForce("GTC"); }
        public static TimeInForce FOK { get => new TimeInForce("FOK"); }
        public static TimeInForce IOC { get => new TimeInForce("IOC"); }

        public string Value { get; private set; }

        public static implicit operator string(TimeInForce enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}