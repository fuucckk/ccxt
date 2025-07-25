using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

public partial class BaseTest
{
        public void helperTestHandleMarketTypeAndParams()
        {
            var exchange = new ccxt.Exchange(new Dictionary<string, object>() {
                { "id", "sampleexchange" },
                { "options", new Dictionary<string, object>() {
                    { "defaultType", "valueFromOptions" },
                    { "fetchX", new Dictionary<string, object>() {
                        { "defaultType", "valueFromMethodOptions" },
                    } },
                } },
            });
            object initialParams = new Dictionary<string, object>() {
                { "defaultType", "valueFromParam" },
            };
            object market = exchange.safeMarket("TEST1/TEST2");
            ((IDictionary<string,object>)market)["type"] = "spot";
            //
            // ########### test different variations ###########
            //
            // case #1, should prevail: param
            //
            var marketType1params1Variable = exchange.handleMarketTypeAndParams("fetchX", market, initialParams, "valueDefault");
            var marketType1 = ((IList<object>) marketType1params1Variable)[0];
            var params1 = ((IList<object>) marketType1params1Variable)[1];
            Assert(inOp(initialParams, "defaultType"));
            Assert(!isTrue((inOp(params1, "defaultType"))));
            Assert(isEqual(marketType1, "valueFromParam"));
            //
            // case #2, should prevail: market.type
            //
            var marketType2params2Variable = exchange.handleMarketTypeAndParams("fetchX", market, new Dictionary<string, object>() {}, "valueDefault");
            var marketType2 = ((IList<object>) marketType2params2Variable)[0];
            var params2 = ((IList<object>) marketType2params2Variable)[1];
            Assert(isEqual(marketType2, "spot"));
            //
            // case #3, should prevail: valueDefault
            //
            var marketType3params3Variable = exchange.handleMarketTypeAndParams("fetchX", null, new Dictionary<string, object>() {}, "valueDefault");
            var marketType3 = ((IList<object>) marketType3params3Variable)[0];
            var params3 = ((IList<object>) marketType3params3Variable)[1];
            Assert(isEqual(marketType3, "valueDefault"));
            //
            // case #4, should prevail: method options
            //
            var marketType4params4Variable = exchange.handleMarketTypeAndParams("fetchX", null, new Dictionary<string, object>() {});
            var marketType4 = ((IList<object>) marketType4params4Variable)[0];
            var params4 = ((IList<object>) marketType4params4Variable)[1];
            Assert(isEqual(marketType4, "valueFromMethodOptions"));
            //
            // case #5, should prevail: options
            //
            var marketType5params5Variable = exchange.handleMarketTypeAndParams("fetchY", null, new Dictionary<string, object>() {}, null);
            var marketType5 = ((IList<object>) marketType5params5Variable)[0];
            var params5 = ((IList<object>) marketType5params5Variable)[1];
            Assert(isEqual(marketType5, "valueFromOptions"));
            //
            // case #6, should prevail: spot (because hardcoded in base)
            //
            ((IDictionary<string,object>)exchange.options)["defaultType"] = null;
            var marketType6params6Variable = exchange.handleMarketTypeAndParams("fetchY", null, new Dictionary<string, object>() {}, null);
            var marketType6 = ((IList<object>) marketType6params6Variable)[0];
            var params6 = ((IList<object>) marketType6params6Variable)[1];
            Assert(isEqual(marketType6, "spot"));
            // fake Assertion to avoid unused vars
            Assert(isTrue(isTrue(isTrue(isTrue(isTrue(!isEqual(params1, null)) || isTrue(!isEqual(params2, null))) || isTrue(!isEqual(params3, null))) || isTrue(!isEqual(params4, null))) || isTrue(!isEqual(params5, null))) || isTrue(!isEqual(params6, null)));
        }
        public void helperTestHandleNetworkRequest()
        {
            var exchange = new ccxt.Exchange(new Dictionary<string, object>() {
                { "id", "sampleexchange" },
                { "options", new Dictionary<string, object>() {
                    { "networks", new Dictionary<string, object>() {
                        { "XYZ", "Xyz" },
                    } },
                } },
            });
            exchange.currencies = exchange.createSafeDictionary(); // todo: initialize in C# base files
            object currencyCode = "ETH"; // todo: in future with complex cases
            // no-case
            var request1params1Variable = exchange.handleRequestNetwork(new Dictionary<string, object>() {
            { "network", "XYZ" },
        }, new Dictionary<string, object>() {}, "chain_id", currencyCode, false);
            var request1 = ((IList<object>) request1params1Variable)[0];
            var params1 = ((IList<object>) request1params1Variable)[1];
            Assert(!isTrue((inOp(params1, "network"))));
            Assert(inOp(request1, "chain_id"));
            Assert(isEqual(getValue(request1, "chain_id"), "Xyz"));
        }
        public void testHandleMethods()
        {
            helperTestHandleMarketTypeAndParams();
            helperTestHandleNetworkRequest();
        }
}