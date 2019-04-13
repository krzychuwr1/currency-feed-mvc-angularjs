using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyFeedApp.Configuration
{
    public class ExternalApiConfiguration : IExternalApiConfiguration
    {
        public string ExternalApiUrl => "https://api.exchangeratesapi.io/history?start_at=2018-01-01&end_at=2018-09-01&symbols=USD,EUR&base=PLN";
    }
}