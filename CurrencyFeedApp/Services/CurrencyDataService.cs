using CurrencyFeedApp.Configuration;
using CurrencyFeedApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CurrencyFeedApp.Services
{
    public class CurrencyDataService : ICurrencyDataService
    {
        private IExternalApiConfiguration _externalApiConfiguration;

        public CurrencyDataService(IExternalApiConfiguration externalApiConfiguration)
        {
            _externalApiConfiguration = externalApiConfiguration;
        }

        public async Task<ExchangeRatesResponse> GetData()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_externalApiConfiguration.ExternalApiUrl);
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ExchangeRatesResponse>(responseJson);
            }
        }
    }
}