// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import assert from 'assert';
import testOrderBook from './base/test.orderBook.js';
async function testFetchOrderBooks(exchange, skippedProperties) {
    const method = 'fetchOrderBooks';
    const symbol = exchange.symbols[0];
    const orderBooks = await exchange.fetchOrderBooks([symbol]);
    assert(typeof orderBooks === 'object', exchange.id + ' ' + method + ' must return an object. ' + exchange.json(orderBooks));
    const orderBookKeys = Object.keys(orderBooks);
    assert(orderBookKeys.length, exchange.id + ' ' + method + ' returned 0 length data');
    for (let i = 0; i < orderBookKeys.length; i++) {
        const symbolInner = orderBookKeys[i];
        testOrderBook(exchange, skippedProperties, method, orderBooks[symbolInner], symbolInner);
    }
    return true;
}
export default testFetchOrderBooks;
