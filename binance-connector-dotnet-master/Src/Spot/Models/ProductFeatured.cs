// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot.Models
{
    public struct ProductFeatured
    {
        private ProductFeatured(string value)
        {
            this.Value = value;
        }

        public static ProductFeatured ALL { get => new ProductFeatured("ALL"); }
        public static ProductFeatured TRUE { get => new ProductFeatured("TRUE"); }

        public string Value { get; private set; }

        public static implicit operator string(ProductFeatured enm) => enm.Value;

        public override string ToString() => this.Value.ToString();
    }
}