// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct LoanDirection
    {
        private LoanDirection(string value)
        {
            this.Value = value;
        }

        public static LoanDirection ADDITIONAL { get => new LoanDirection("ADDITIONAL"); }
        public static LoanDirection REDUCED { get => new LoanDirection("REDUCED"); }

        public string Value { get; private set; }

        public static implicit operator string(LoanDirection enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}