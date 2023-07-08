// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct FiatOrderTransactionType
    {
        private FiatOrderTransactionType(string value)
        {
            this.Value = value;
        }

        public static FiatOrderTransactionType DEPOSIT { get => new FiatOrderTransactionType("0"); }
        public static FiatOrderTransactionType WITHDRAW { get => new FiatOrderTransactionType("1"); }

        public string Value { get; private set; }

        public static implicit operator string(FiatOrderTransactionType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}