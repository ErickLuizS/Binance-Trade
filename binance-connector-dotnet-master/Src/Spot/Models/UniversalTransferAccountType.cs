// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct UniversalTransferAccountType
    {
        private UniversalTransferAccountType(string value)
        {
            this.Value = value;
        }

        public static UniversalTransferAccountType SPOT { get => new UniversalTransferAccountType("SPOT"); }
        public static UniversalTransferAccountType USDT_FUTURE { get => new UniversalTransferAccountType("USDT_FUTURE"); }
        public static UniversalTransferAccountType COIN_FUTURE { get => new UniversalTransferAccountType("COIN_FUTURE"); }
        public static UniversalTransferAccountType MARGIN { get => new UniversalTransferAccountType("MARGIN"); }
        public static UniversalTransferAccountType ISOLATED_MARGIN { get => new UniversalTransferAccountType("ISOLATED_MARGIN"); }

        public string Value { get; private set; }

        public static implicit operator string(UniversalTransferAccountType enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}