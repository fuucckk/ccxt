// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

package ccxt

func (this *bitvavo) PublicGetTime (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetTime", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetMarkets (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetMarkets", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetAssets (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetAssets", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetMarketBook (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetMarketBook", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetMarketTrades (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetMarketTrades", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetMarketCandles (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetMarketCandles", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetTickerPrice (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetTickerPrice", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetTickerBook (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetTickerBook", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PublicGetTicker24h (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("publicGetTicker24h", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetAccount (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetAccount", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetOrder (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetOrder", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetOrders (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetOrders", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetOrdersOpen (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetOrdersOpen", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetTrades (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetTrades", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetBalance (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetBalance", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetDeposit (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetDeposit", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetDepositHistory (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetDepositHistory", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateGetWithdrawalHistory (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateGetWithdrawalHistory", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivatePostOrder (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privatePostOrder", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivatePostWithdrawal (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privatePostWithdrawal", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivatePutOrder (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privatePutOrder", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateDeleteOrder (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateDeleteOrder", parameters))
       PanicOnError(ch)
   }()
   return ch
}

func (this *bitvavo) PrivateDeleteOrders (args ...interface{}) <-chan interface{} {
   parameters := GetArg(args, 0, nil)
   ch := make(chan interface{})
   go func() {
       defer close(ch)
       defer func() {
           if r := recover(); r != nil {
               ch <- "panic:" + ToString(r)
           }
       }()
       ch <- (<-this.callEndpoint ("privateDeleteOrders", parameters))
       PanicOnError(ch)
   }()
   return ch
}
