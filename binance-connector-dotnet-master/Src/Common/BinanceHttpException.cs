// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Common
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Binance exception class for any errors throw as a result of communication via http.
    /// </summary>
    public class BinanceHttpException : Exception
    {
        public BinanceHttpException()
        : base()
        {
        }

        public BinanceHttpException(string message)
        : base(message)
        {
        }

        public BinanceHttpException(string message, Exception innerException)
        : base(message, innerException)
        {
        }

        public int StatusCode { get; set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; set; }
    }
}