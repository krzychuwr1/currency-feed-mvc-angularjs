using CurrencyFeedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFeedApp.Services
{
    public interface ICurrencyDataService
    {
        Task<ExchangeRatesResponse> GetData();
    }
}
