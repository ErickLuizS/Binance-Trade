// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot
{
    using System.Net.Http;
    using Binance.Common;

    public abstract class SpotService : BinanceService
    {
        protected const string DEFAULT_SPOT_BASE_URL = "https://api.binance.com";

        public SpotService(HttpClient httpClient, string apiKey, string apiSecret, string baseUrl = DEFAULT_SPOT_BASE_URL)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, apiSecret: apiSecret)
        {
        }

        public SpotService(HttpClient httpClient, string apiKey, IBinanceSignatureService signatureService, string baseUrl = DEFAULT_SPOT_BASE_URL)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, signatureService: signatureService)
        {
        }
    }
}