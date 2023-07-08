// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct PositionStatus
    {
        private PositionStatus(string value)
        {
            this.Value = value;
        }

        public static PositionStatus HOLDING { get => new PositionStatus("HOLDING"); }
        public static PositionStatus REDEEMED { get => new PositionStatus("REDEEMED"); }

        public string Value { get; private set; }

        public static implicit operator string(PositionStatus enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}