// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct FiatPaymentTransactionType
    {
        private FiatPaymentTransactionType(string value)
        {
            this.Value = value;
        }

        public static FiatPaymentTransactionType BUY { get => new FiatPaymentTransactionType("0"); }
        public static FiatPaymentTransactionType SELL { get => new FiatPaymentTransactionType("1"); }

        public string Value { get; private set; }

        public static implicit operator string(FiatPaymentTransactionType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}