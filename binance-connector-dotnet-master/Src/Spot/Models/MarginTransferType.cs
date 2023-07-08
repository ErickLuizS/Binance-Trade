// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct MarginTransferType
    {
        private MarginTransferType(short value)
        {
            this.Value = value;
        }

        public static MarginTransferType SPOT_TO_MARGIN { get => new MarginTransferType(1); }
        public static MarginTransferType MARGIN_TO_SPOT { get => new MarginTransferType(2); }

        public short Value { get; private set; }

        public static implicit operator short(MarginTransferType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}