// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

package ccxt

func (this *zonda) PublicGetIdAll (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("publicGetIdAll", args...)
}

func (this *zonda) PublicGetIdMarket (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("publicGetIdMarket", args...)
}

func (this *zonda) PublicGetIdOrderbook (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("publicGetIdOrderbook", args...)
}

func (this *zonda) PublicGetIdTicker (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("publicGetIdTicker", args...)
}

func (this *zonda) PublicGetIdTrades (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("publicGetIdTrades", args...)
}

func (this *zonda) PrivatePostInfo (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostInfo", args...)
}

func (this *zonda) PrivatePostTrade (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostTrade", args...)
}

func (this *zonda) PrivatePostCancel (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostCancel", args...)
}

func (this *zonda) PrivatePostOrderbook (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostOrderbook", args...)
}

func (this *zonda) PrivatePostOrders (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostOrders", args...)
}

func (this *zonda) PrivatePostTransfer (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostTransfer", args...)
}

func (this *zonda) PrivatePostWithdraw (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostWithdraw", args...)
}

func (this *zonda) PrivatePostHistory (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostHistory", args...)
}

func (this *zonda) PrivatePostTransactions (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("privatePostTransactions", args...)
}

func (this *zonda) V1_01PublicGetTradingTicker (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingTicker", args...)
}

func (this *zonda) V1_01PublicGetTradingTickerSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingTickerSymbol", args...)
}

func (this *zonda) V1_01PublicGetTradingStats (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingStats", args...)
}

func (this *zonda) V1_01PublicGetTradingStatsSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingStatsSymbol", args...)
}

func (this *zonda) V1_01PublicGetTradingOrderbookSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingOrderbookSymbol", args...)
}

func (this *zonda) V1_01PublicGetTradingTransactionsSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingTransactionsSymbol", args...)
}

func (this *zonda) V1_01PublicGetTradingCandleHistorySymbolResolution (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PublicGetTradingCandleHistorySymbolResolution", args...)
}

func (this *zonda) V1_01PrivateGetApiPaymentsDepositsCryptoAddresses (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetApiPaymentsDepositsCryptoAddresses", args...)
}

func (this *zonda) V1_01PrivateGetPaymentsWithdrawalDetailId (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetPaymentsWithdrawalDetailId", args...)
}

func (this *zonda) V1_01PrivateGetPaymentsDepositDetailId (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetPaymentsDepositDetailId", args...)
}

func (this *zonda) V1_01PrivateGetTradingOffer (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetTradingOffer", args...)
}

func (this *zonda) V1_01PrivateGetTradingStopOffer (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetTradingStopOffer", args...)
}

func (this *zonda) V1_01PrivateGetTradingConfigSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetTradingConfigSymbol", args...)
}

func (this *zonda) V1_01PrivateGetTradingHistoryTransactions (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetTradingHistoryTransactions", args...)
}

func (this *zonda) V1_01PrivateGetBalancesBITBAYHistory (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetBalancesBITBAYHistory", args...)
}

func (this *zonda) V1_01PrivateGetBalancesBITBAYBalance (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetBalancesBITBAYBalance", args...)
}

func (this *zonda) V1_01PrivateGetFiatCantorRateBaseIdQuoteId (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetFiatCantorRateBaseIdQuoteId", args...)
}

func (this *zonda) V1_01PrivateGetFiatCantorHistory (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetFiatCantorHistory", args...)
}

func (this *zonda) V1_01PrivateGetClientPaymentsV2CustomerCryptoCurrencyChannelsDeposit (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetClientPaymentsV2CustomerCryptoCurrencyChannelsDeposit", args...)
}

func (this *zonda) V1_01PrivateGetClientPaymentsV2CustomerCryptoCurrencyChannelsWithdrawal (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetClientPaymentsV2CustomerCryptoCurrencyChannelsWithdrawal", args...)
}

func (this *zonda) V1_01PrivateGetClientPaymentsV2CustomerCryptoDepositFee (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetClientPaymentsV2CustomerCryptoDepositFee", args...)
}

func (this *zonda) V1_01PrivateGetClientPaymentsV2CustomerCryptoWithdrawalFee (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateGetClientPaymentsV2CustomerCryptoWithdrawalFee", args...)
}

func (this *zonda) V1_01PrivatePostTradingOfferSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostTradingOfferSymbol", args...)
}

func (this *zonda) V1_01PrivatePostTradingStopOfferSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostTradingStopOfferSymbol", args...)
}

func (this *zonda) V1_01PrivatePostTradingConfigSymbol (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostTradingConfigSymbol", args...)
}

func (this *zonda) V1_01PrivatePostBalancesBITBAYBalance (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostBalancesBITBAYBalance", args...)
}

func (this *zonda) V1_01PrivatePostBalancesBITBAYBalanceTransferSourceDestination (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostBalancesBITBAYBalanceTransferSourceDestination", args...)
}

func (this *zonda) V1_01PrivatePostFiatCantorExchange (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostFiatCantorExchange", args...)
}

func (this *zonda) V1_01PrivatePostApiPaymentsWithdrawalsCrypto (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostApiPaymentsWithdrawalsCrypto", args...)
}

func (this *zonda) V1_01PrivatePostApiPaymentsWithdrawalsFiat (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostApiPaymentsWithdrawalsFiat", args...)
}

func (this *zonda) V1_01PrivatePostClientPaymentsV2CustomerCryptoDeposit (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostClientPaymentsV2CustomerCryptoDeposit", args...)
}

func (this *zonda) V1_01PrivatePostClientPaymentsV2CustomerCryptoWithdrawal (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePostClientPaymentsV2CustomerCryptoWithdrawal", args...)
}

func (this *zonda) V1_01PrivateDeleteTradingOfferSymbolIdSidePrice (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateDeleteTradingOfferSymbolIdSidePrice", args...)
}

func (this *zonda) V1_01PrivateDeleteTradingStopOfferSymbolIdSidePrice (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivateDeleteTradingStopOfferSymbolIdSidePrice", args...)
}

func (this *zonda) V1_01PrivatePutBalancesBITBAYBalanceId (args ...interface{}) <-chan interface{} {
   return this.callEndpointAsync("v1_01PrivatePutBalancesBITBAYBalanceId", args...)
}
