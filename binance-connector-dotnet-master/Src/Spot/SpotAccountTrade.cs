// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Binance.Spot
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Binance.Common;
    using Binance.Spot.Models;

    public class SpotAccountTrade : SpotService
    {
        public SpotAccountTrade(string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null, string apiSecret = null)
        : this(new HttpClient(), baseUrl: baseUrl, apiKey: apiKey, apiSecret: apiSecret)
        {
        }

        public SpotAccountTrade(HttpClient httpClient, string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null, string apiSecret = null)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, apiSecret: apiSecret)
        {
        }

        public SpotAccountTrade(HttpClient httpClient, IBinanceSignatureService signatureService, string baseUrl = DEFAULT_SPOT_BASE_URL, string apiKey = null)
        : base(httpClient, baseUrl: baseUrl, apiKey: apiKey, signatureService: signatureService)
        {
        }

        private const string TEST_NEW_ORDER = "/api/v3/order/test";

        /// <summary>
        /// Test new order creation and signature/recvWindow long.<para />
        /// Creates and validates a new order but does not send it into the matching engine.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="side"></param>
        /// <param name="type">Order type.</param>
        /// <param name="timeInForce">Order time in force.</param>
        /// <param name="quantity">Order quantity.</param>
        /// <param name="quoteOrderQty">Quote quantity.</param>
        /// <param name="price">Order price.</param>
        /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="strategyId">Identify an order as part of a strategy.</param>
        /// <param name="strategyType">The value cannot be less than 1000000.</param>
        /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
        /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>OK.</returns>
        public async Task<string> TestNewOrder(string symbol, Side side, OrderType type, TimeInForce? timeInForce = null, decimal? quantity = null, decimal? quoteOrderQty = null, decimal? price = null, string newClientOrderId = null, int? strategyId = null, int? strategyType = null, decimal? stopPrice = null, decimal? trailingDelta = null, decimal? icebergQty = null, NewOrderResponseType? newOrderRespType = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                TEST_NEW_ORDER,
                HttpMethod.Post,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "side", side },
                    { "type", type },
                    { "timeInForce", timeInForce },
                    { "quantity", quantity },
                    { "quoteOrderQty", quoteOrderQty },
                    { "price", price },
                    { "newClientOrderId", newClientOrderId },
                    { "strategyId", strategyId },
                    { "strategyType", strategyType },
                    { "stopPrice", stopPrice },
                    { "trailingDelta", trailingDelta },
                    { "icebergQty", icebergQty },
                    { "newOrderRespType", newOrderRespType },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string NEW_ORDER = "/api/v3/order";

        /// <summary>
        /// Send in a new order.<para />
        /// - `LIMIT_MAKER` are `LIMIT` orders that will be rejected if they would immediately match and trade as a taker.<para />
        /// - `STOP_LOSS` and `TAKE_PROFIT` will execute a `MARKET` order when the `stopPrice` is reached.<para />
        /// - Any `LIMIT` or `LIMIT_MAKER` type order can be made an iceberg order by sending an `icebergQty`.<para />
        /// - Any order with an `icebergQty` MUST have `timeInForce` set to `GTC`.<para />
        /// - `MARKET` orders using `quantity` specifies how much a user wants to buy or sell based on the market price.<para />
        /// - `MARKET` orders using `quoteOrderQty` specifies the amount the user wants to spend (when buying) or receive (when selling) of the quote asset; the correct quantity will be determined based on the market liquidity and `quoteOrderQty`.<para />
        /// - `MARKET` orders using `quoteOrderQty` will not break `LOT_SIZE` filter rules; the order will execute a quantity that will have the notional value as close as possible to `quoteOrderQty`.<para />
        /// - same `newClientOrderId` can be accepted only when the previous one is filled, otherwise the order will be rejected.<para />
        /// Trigger order price rules against market price for both `MARKET` and `LIMIT` versions:.<para />
        /// - Price above market price: `STOP_LOSS` `BUY`, `TAKE_PROFIT` `SELL`.<para />
        /// - Price below market price: `STOP_LOSS` `SELL`, `TAKE_PROFIT` `BUY`.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="side"></param>
        /// <param name="type">Order type.</param>
        /// <param name="timeInForce">Order time in force.</param>
        /// <param name="quantity">Order quantity.</param>
        /// <param name="quoteOrderQty">Quote quantity.</param>
        /// <param name="price">Order price.</param>
        /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="strategyId">Identify an order as part of a strategy.</param>
        /// <param name="strategyType">The value cannot be less than 1000000.</param>
        /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
        /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Order result.</returns>
        public async Task<string> NewOrder(string symbol, Side side, OrderType type, TimeInForce? timeInForce = null, decimal? quantity = null, decimal? quoteOrderQty = null, decimal? price = null, string newClientOrderId = null, int? strategyId = null, int? strategyType = null, decimal? stopPrice = null, decimal? trailingDelta = null, decimal? icebergQty = null, NewOrderResponseType? newOrderRespType = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                NEW_ORDER,
                HttpMethod.Post,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "side", side },
                    { "type", type },
                    { "timeInForce", timeInForce },
                    { "quantity", quantity },
                    { "quoteOrderQty", quoteOrderQty },
                    { "price", price },
                    { "newClientOrderId", newClientOrderId },
                    { "strategyId", strategyId },
                    { "strategyType", strategyType },
                    { "stopPrice", stopPrice },
                    { "trailingDelta", trailingDelta },
                    { "icebergQty", icebergQty },
                    { "newOrderRespType", newOrderRespType },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string CANCEL_ORDER = "/api/v3/order";

        /// <summary>
        /// Cancel an active order.<para />
        /// Either `orderId` or `origClientOrderId` must be sent.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="orderId">Order id.</param>
        /// <param name="origClientOrderId">Order id from client.</param>
        /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Cancelled order.</returns>
        public async Task<string> CancelOrder(string symbol, long? orderId = null, string origClientOrderId = null, string newClientOrderId = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                CANCEL_ORDER,
                HttpMethod.Delete,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "orderId", orderId },
                    { "origClientOrderId", origClientOrderId },
                    { "newClientOrderId", newClientOrderId },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string CANCEL_ALL_OPEN_ORDERS_ON_A_SYMBOL = "/api/v3/openOrders";

        /// <summary>
        /// Cancels all active orders on a symbol.<para />
        /// This includes OCO orders.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Cancelled orders.</returns>
        public async Task<string> CancelAllOpenOrdersOnASymbol(string symbol, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                CANCEL_ALL_OPEN_ORDERS_ON_A_SYMBOL,
                HttpMethod.Delete,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string QUERY_ORDER = "/api/v3/order";

        /// <summary>
        /// Check an order's status.<para />
        /// - Either `orderId` or `origClientOrderId` must be sent.<para />
        /// - For some historical orders `cummulativeQuoteQty` will be &lt; 0, meaning the data is not available at this time.<para />
        /// Weight(IP): 2.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="orderId">Order id.</param>
        /// <param name="origClientOrderId">Order id from client.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Order details.</returns>
        public async Task<string> QueryOrder(string symbol, long? orderId = null, string origClientOrderId = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                QUERY_ORDER,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "orderId", orderId },
                    { "origClientOrderId", origClientOrderId },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string CURRENT_OPEN_ORDERS = "/api/v3/openOrders";

        /// <summary>
        /// Get all open orders on a symbol. Careful when accessing this with no symbol.<para />
        /// Weight(IP):.<para />
        /// - `3` for a single symbol;.<para />
        /// - `40` when the symbol parameter is omitted;.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Current open orders.</returns>
        public async Task<string> CurrentOpenOrders(string symbol = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                CURRENT_OPEN_ORDERS,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string ALL_ORDERS = "/api/v3/allOrders";

        /// <summary>
        /// Get all account orders; active, canceled, or filled..<para />
        /// - If `orderId` is set, it will get orders &gt;= that `orderId`. Otherwise most recent orders are returned.<para />
        /// - For some historical orders `cummulativeQuoteQty` will be &lt; 0, meaning the data is not available at this time.<para />
        /// - If `startTime` and/or `endTime` provided, `orderId` is not required.<para />
        /// Weight(IP): 10.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="orderId">Order id.</param>
        /// <param name="startTime">UTC timestamp in ms.</param>
        /// <param name="endTime">UTC timestamp in ms.</param>
        /// <param name="limit">Default 500; max 1000.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Current open orders.</returns>
        public async Task<string> AllOrders(string symbol, long? orderId = null, long? startTime = null, long? endTime = null, int? limit = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                ALL_ORDERS,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "orderId", orderId },
                    { "startTime", startTime },
                    { "endTime", endTime },
                    { "limit", limit },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string NEW_OCO = "/api/v3/order/oco";

        /// <summary>
        /// Send in a new OCO.<para />
        /// - Price Restrictions:.<para />
        ///   - `SELL`: Limit Price &gt; Last Price &gt; Stop Price.<para />
        ///   - `BUY`: Limit Price &lt; Last Price &lt; Stop Price.<para />
        /// - Quantity Restrictions:.<para />
        ///     - Both legs must have the same quantity.<para />
        ///     - `ICEBERG` quantities however do not have to be the same.<para />
        /// - Order Rate Limit.<para />
        ///     - `OCO` counts as 2 orders against the order rate limit.<para />
        ///     .<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="side"></param>
        /// <param name="quantity"></param>
        /// <param name="price">Order price.</param>
        /// <param name="stopPrice"></param>
        /// <param name="listClientOrderId">A unique Id for the entire orderList.</param>
        /// <param name="limitClientOrderId">A unique Id for the limit order.</param>
        /// <param name="limitStrategyId">Identify limit order as part of a strategy.</param>
        /// <param name="limitStrategyType">The value cannot be less than 1000000.</param>
        /// <param name="limitIcebergQty"></param>
        /// <param name="trailingDelta"></param>
        /// <param name="stopClientOrderId">A unique Id for the stop loss/stop loss limit leg.</param>
        /// <param name="stopStrategyId">Identify stop order as part of a strategy.</param>
        /// <param name="stopStrategyType">The value cannot be less than 1000000.</param>
        /// <param name="stopLimitPrice">If provided, stopLimitTimeInForce is required.</param>
        /// <param name="stopIcebergQty"></param>
        /// <param name="stopLimitTimeInForce"></param>
        /// <param name="newOrderRespType">Set the response JSON.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>New OCO details.</returns>
        public async Task<string> NewOco(string symbol, Side side, decimal quantity, decimal price, decimal stopPrice, string listClientOrderId = null, string limitClientOrderId = null, int? limitStrategyId = null, int? limitStrategyType = null, decimal? limitIcebergQty = null, decimal? trailingDelta = null, string stopClientOrderId = null, int? stopStrategyId = null, int? stopStrategyType = null, decimal? stopLimitPrice = null, decimal? stopIcebergQty = null, TimeInForce? stopLimitTimeInForce = null, NewOrderResponseType? newOrderRespType = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                NEW_OCO,
                HttpMethod.Post,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "listClientOrderId", listClientOrderId },
                    { "side", side },
                    { "quantity", quantity },
                    { "limitClientOrderId", limitClientOrderId },
                    { "limitStrategyId", limitStrategyId },
                    { "limitStrategyType", limitStrategyType },
                    { "price", price },
                    { "limitIcebergQty", limitIcebergQty },
                    { "trailingDelta", trailingDelta },
                    { "stopClientOrderId", stopClientOrderId },
                    { "stopPrice", stopPrice },
                    { "stopStrategyId", stopStrategyId },
                    { "stopStrategyType", stopStrategyType },
                    { "stopLimitPrice", stopLimitPrice },
                    { "stopIcebergQty", stopIcebergQty },
                    { "stopLimitTimeInForce", stopLimitTimeInForce },
                    { "newOrderRespType", newOrderRespType },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string CANCEL_OCO = "/api/v3/orderList";

        /// <summary>
        /// Cancel an entire Order List.<para />
        /// Canceling an individual leg will cancel the entire OCO.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="orderListId">Order list id.</param>
        /// <param name="listClientOrderId">A unique Id for the entire orderList.</param>
        /// <param name="newClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Report on deleted OCO.</returns>
        public async Task<string> CancelOco(string symbol, long? orderListId = null, string listClientOrderId = null, string newClientOrderId = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                CANCEL_OCO,
                HttpMethod.Delete,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "orderListId", orderListId },
                    { "listClientOrderId", listClientOrderId },
                    { "newClientOrderId", newClientOrderId },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string QUERY_OCO = "/api/v3/orderList";

        /// <summary>
        /// Retrieves a specific OCO based on provided optional parameters.<para />
        /// Weight(IP): 2.
        /// </summary>
        /// <param name="orderListId">Order list id.</param>
        /// <param name="origClientOrderId">Order id from client.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>OCO details.</returns>
        public async Task<string> QueryOco(long? orderListId = null, string origClientOrderId = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                QUERY_OCO,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "orderListId", orderListId },
                    { "origClientOrderId", origClientOrderId },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string QUERY_ALL_OCO = "/api/v3/allOrderList";

        /// <summary>
        /// Retrieves all OCO based on provided optional parameters.<para />
        /// Weight(IP): 10.
        /// </summary>
        /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
        /// <param name="startTime">UTC timestamp in ms.</param>
        /// <param name="endTime">UTC timestamp in ms.</param>
        /// <param name="limit">Default 500; max 1000.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>List of OCO orders.</returns>
        public async Task<string> QueryAllOco(long? fromId = null, long? startTime = null, long? endTime = null, int? limit = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                QUERY_ALL_OCO,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "fromId", fromId },
                    { "startTime", startTime },
                    { "endTime", endTime },
                    { "limit", limit },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string QUERY_OPEN_OCO = "/api/v3/openOrderList";

        /// <summary>
        /// Weight(IP): 3.
        /// </summary>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>List of OCO orders.</returns>
        public async Task<string> QueryOpenOco(long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                QUERY_OPEN_OCO,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string ACCOUNT_INFORMATION = "/api/v3/account";

        /// <summary>
        /// Get current account information.<para />
        /// Weight(IP): 10.
        /// </summary>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Account details.</returns>
        public async Task<string> AccountInformation(long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                ACCOUNT_INFORMATION,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string ACCOUNT_TRADE_LIST = "/api/v3/myTrades";

        /// <summary>
        /// Get trades for a specific account and symbol.<para />
        /// If `fromId` is set, it will get id &gt;= that `fromId`. Otherwise most recent orders are returned.<para />
        /// Weight(IP): 10.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="orderId">This can only be used in combination with symbol.</param>
        /// <param name="startTime">UTC timestamp in ms.</param>
        /// <param name="endTime">UTC timestamp in ms.</param>
        /// <param name="fromId">Trade id to fetch from. Default gets most recent trades.</param>
        /// <param name="limit">Default 500; max 1000.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>List of trades.</returns>
        public async Task<string> AccountTradeList(string symbol, long? orderId = null, long? startTime = null, long? endTime = null, long? fromId = null, int? limit = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                ACCOUNT_TRADE_LIST,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "orderId", orderId },
                    { "startTime", startTime },
                    { "endTime", endTime },
                    { "fromId", fromId },
                    { "limit", limit },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string QUERY_CURRENT_ORDER_COUNT_USAGE = "/api/v3/rateLimit/order";

        /// <summary>
        /// Displays the user's current order count usage for all intervals.<para />
        /// Weight(IP): 20.
        /// </summary>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Order rate limits.</returns>
        public async Task<string> QueryCurrentOrderCountUsage(long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                QUERY_CURRENT_ORDER_COUNT_USAGE,
                HttpMethod.Get,
                query: new Dictionary<string, object>
                {
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }

        private const string CANCEL_AN_EXISTING_ORDER_AND_SEND_A_NEW_ORDER = "/api/v3/order/cancelReplace";

        /// <summary>
        /// Cancels an existing order and places a new order on the same symbol.<para />
        /// Filters are evaluated before the cancel order is placed.<para />
        /// If the new order placement is successfully sent to the engine, the order count will increase by 1.<para />
        /// Weight(IP): 1.
        /// </summary>
        /// <param name="symbol">Trading symbol, e.g. BNBUSDT.</param>
        /// <param name="side"></param>
        /// <param name="type">Order type.</param>
        /// <param name="cancelReplaceMode">- `STOP_ON_FAILURE` If the cancel request fails, the new order placement will not be attempted.<para />
        /// - `ALLOW_FAILURES` If new order placement will be attempted even if cancel request fails.</param>
        /// <param name="timeInForce">Order time in force.</param>
        /// <param name="quantity">Order quantity.</param>
        /// <param name="quoteOrderQty">Quote quantity.</param>
        /// <param name="price">Order price.</param>
        /// <param name="cancelNewClientOrderId">Used to uniquely identify this cancel. Automatically generated by default.</param>
        /// <param name="cancelOrigClientOrderId">Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence.</param>
        /// <param name="cancelOrderId">Either the cancelOrigClientOrderId or cancelOrderId must be provided. If both are provided, cancelOrderId takes precedence.</param>
        /// <param name="newClientOrderId">Used to identify the new order. Automatically generated by default.</param>
        /// <param name="strategyId">Identify an order as part of a strategy.</param>
        /// <param name="strategyType">The value cannot be less than 1000000.</param>
        /// <param name="stopPrice">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="trailingDelta">Used with STOP_LOSS, STOP_LOSS_LIMIT, TAKE_PROFIT, and TAKE_PROFIT_LIMIT orders.</param>
        /// <param name="icebergQty">Used with LIMIT, STOP_LOSS_LIMIT, and TAKE_PROFIT_LIMIT to create an iceberg order.</param>
        /// <param name="newOrderRespType">Set the response JSON. MARKET and LIMIT order types default to FULL, all other orders default to ACK.</param>
        /// <param name="recvWindow">The value cannot be greater than 60000.</param>
        /// <returns>Operation details.</returns>
        public async Task<string> CancelAnExistingOrderAndSendANewOrder(string symbol, Side side, OrderType type, string cancelReplaceMode, TimeInForce? timeInForce = null, decimal? quantity = null, decimal? quoteOrderQty = null, decimal? price = null, string cancelNewClientOrderId = null, string cancelOrigClientOrderId = null, long? cancelOrderId = null, string newClientOrderId = null, int? strategyId = null, int? strategyType = null, decimal? stopPrice = null, decimal? trailingDelta = null, decimal? icebergQty = null, NewOrderResponseType? newOrderRespType = null, long? recvWindow = null)
        {
            var result = await this.SendSignedAsync<string>(
                CANCEL_AN_EXISTING_ORDER_AND_SEND_A_NEW_ORDER,
                HttpMethod.Post,
                query: new Dictionary<string, object>
                {
                    { "symbol", symbol },
                    { "side", side },
                    { "type", type },
                    { "cancelReplaceMode", cancelReplaceMode },
                    { "timeInForce", timeInForce },
                    { "quantity", quantity },
                    { "quoteOrderQty", quoteOrderQty },
                    { "price", price },
                    { "cancelNewClientOrderId", cancelNewClientOrderId },
                    { "cancelOrigClientOrderId", cancelOrigClientOrderId },
                    { "cancelOrderId", cancelOrderId },
                    { "newClientOrderId", newClientOrderId },
                    { "strategyId", strategyId },
                    { "strategyType", strategyType },
                    { "stopPrice", stopPrice },
                    { "trailingDelta", trailingDelta },
                    { "icebergQty", icebergQty },
                    { "newOrderRespType", newOrderRespType },
                    { "recvWindow", recvWindow },
                    { "timestamp", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() },
                });

            return result;
        }
    }
}