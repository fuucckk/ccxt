namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class latoken
{
    /// <summary>
    /// fetches the current integer timestamp in milliseconds from the exchange server
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Time/operation/currentTime"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int</term> the current integer timestamp in milliseconds from the exchange server.</returns>
    public async Task<Int64> FetchTime(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTime(parameters);
        return (Int64)res;
    }
    /// <summary>
    /// retrieves data on all markets for latoken
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Pair/operation/getActivePairs"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> an array of objects representing market data.</returns>
    public async Task<List<MarketInterface>> FetchMarkets(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarkets(parameters);
        return ((IList<object>)res).Select(item => new MarketInterface(item)).ToList<MarketInterface>();
    }
    /// <summary>
    /// query for balance and get the amount of funds available for trading or funds locked in orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Account/operation/getBalancesByUser"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}.</returns>
    public async Task<Balances> FetchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchBalance(parameters);
        return new Balances(res);
    }
    /// <summary>
    /// fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order-Book/operation/getOrderBook"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<OrderBook> FetchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderBook(symbol, limit, parameters);
        return new OrderBook(res);
    }
    /// <summary>
    /// fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Ticker/operation/getTicker"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Ticker> FetchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// fetches price tickers for multiple markets, statistical information calculated over the past 24 hours for each market
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Ticker/operation/getAllTickers"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Tickers> FetchTickers(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTickers(symbols, parameters);
        return new Tickers(res);
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Trade/operation/getTradesByPair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest trade to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of trades to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> FetchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch the trading fees for a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Trade/operation/getFeeByPair"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Trade/operation/getAuthFeeByPair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [fee structure]{@link https://docs.ccxt.com/#/?id=fee-structure}.</returns>
    public async Task<TradingFeeInterface> FetchTradingFee(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTradingFee(symbol, parameters);
        return new TradingFeeInterface(res);
    }
    public async Task<Dictionary<string, object>> FetchPublicTradingFee(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchPublicTradingFee(symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    public async Task<Dictionary<string, object>> FetchPrivateTradingFee(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchPrivateTradingFee(symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// fetch all trades made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Trade/operation/getTradesByTrader"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Trade/operation/getTradesByAssetAndTrader"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch trades for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of trades structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}.</returns>
    public async Task<List<Trade>> FetchMyTrades(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchMyTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch all unfilled currently open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/getMyActiveOrdersByPair"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/getMyActiveStopOrdersByPair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch open orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of  open orders structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// boolean : true if fetching trigger orders
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchOpenOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOpenOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/getMyOrders"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/getMyOrdersByPair"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/getMyStopOrders"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/getMyStopOrdersByPair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// boolean : true if fetching trigger orders
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on an order made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/getOrderById"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/getStopOrderById"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>symbol</term>
    /// <description>
    /// string : not used by latoken fetchOrder
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// boolean : true if fetching a trigger order
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> FetchOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// create a trade order
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/placeOrder"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/placeStopOrder"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>price</term>
    /// <description>
    /// float : the price at which the order is to be fulfilled, in units of the quote currency, ignored in market orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.triggerPrice</term>
    /// <description>
    /// float : the price at which a trigger order is triggered at
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.condition</term>
    /// <description>
    /// string : "GTC", "IOC", or  "FOK"
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.clientOrderId</term>
    /// <description>
    /// string : [ 0 .. 50 ] characters, client's custom order id (free field for your convenience)
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CreateOrder(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.createOrder(symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// cancels an open order
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/cancelOrder"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/StopOrder/operation/cancelStopOrder"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// boolean : true if cancelling a trigger order
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CancelOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// cancel all open orders in a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/cancelAllOrders"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Order/operation/cancelAllOrdersByPair"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// boolean : true if cancelling trigger orders
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> CancelAllOrders(string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelAllOrders(symbol, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// use fetchDepositsWithdrawals instead
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Transaction/operation/getUserTransactions"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest transaction, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : max number of transactions to return, default is undefined
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a list of [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchTransactions(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTransactions(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch a history of internal transfers made on an account
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Transfer/operation/getUsersTransfers"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch transfers for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of  transfers structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transfer structures]{@link https://docs.ccxt.com/#/?id=transfer-structure}.</returns>
    public async Task<List<TransferEntry>> FetchTransfers(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTransfers(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new TransferEntry(item)).ToList<TransferEntry>();
    }
    /// <summary>
    /// transfer currency internally between wallets on the same account
    /// </summary>
    /// <remarks>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Transfer/operation/transferByEmail"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Transfer/operation/transferById"/>  <br/>
    /// See <see href="https://api.latoken.com/doc/v2/#tag/Transfer/operation/transferByPhone"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}.</returns>
    public async Task<TransferEntry> Transfer(string code, double amount, string fromAccount, string toAccount, Dictionary<string, object> parameters = null)
    {
        var res = await this.transfer(code, amount, fromAccount, toAccount, parameters);
        return new TransferEntry(res);
    }
}
