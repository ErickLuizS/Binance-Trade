// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Common
{
    using System;

    /// <summary>
    /// Binance exception class for any errors throw as a result internal server issues.
    /// </summary>
    public class BinanceServerException : BinanceHttpException
    {
        public BinanceServerException()
        : base()
        {
        }

        public BinanceServerException(string message)
        : base(message)
        {
            this.Message = message;
        }

        public BinanceServerException(string message, Exception innerException)
        : base(message, innerException)
        {
            this.Message = message;
        }

        public new string Message { get; protected set; }
    }
}