// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct SortBy
    {
        private SortBy(string value)
        {
            this.Value = value;
        }

        public static SortBy START_TIME { get => new SortBy("START_TIME"); }
        public static SortBy LOT_SIZE { get => new SortBy("LOT_SIZE"); }
        public static SortBy INTEREST_RATE { get => new SortBy("INTEREST_RATE"); }
        public static SortBy DURATION { get => new SortBy("DURATION"); }

        public string Value { get; private set; }

        public static implicit operator string(SortBy enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}