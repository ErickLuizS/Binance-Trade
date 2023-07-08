// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct CrossMarginTransferType
    {
        private CrossMarginTransferType(string value)
        {
            this.Value = value;
        }

        public static CrossMarginTransferType ROLL_IN { get => new CrossMarginTransferType("ROLL_IN"); }
        public static CrossMarginTransferType ROLL_OUT { get => new CrossMarginTransferType("ROLL_OUT"); }

        public string Value { get; private set; }

        public static implicit operator string(CrossMarginTransferType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}