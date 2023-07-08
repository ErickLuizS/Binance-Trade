// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Common
{
    /// <summary>
    /// Interface for signing payloads.
    /// </summary>
    public interface IBinanceSignatureService
    {
        string Sign(string payload);
    }
}