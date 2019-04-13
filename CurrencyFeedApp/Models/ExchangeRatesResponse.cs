using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyFeedApp.Models
{
    public class ExchangeRatesResponse
    {
        public string @base { get; set; }
        public Dictionary<string, SingleExchangeRate> rates { get; set; }
    }
}