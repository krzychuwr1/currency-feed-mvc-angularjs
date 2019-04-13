using CurrencyFeedApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace CurrencyFeedApp.Controllers
{
    public class CurrencyDataController : ApiController
    {
        private static readonly string ExternalApiUrl = "https://api.exchangeratesapi.io/history?start_at=2018-01-01&end_at=2018-09-01&symbols=USD,EUR&base=PLN";

        [HttpGet]
        public async Task<JsonResult<ExchangeRatesResponse>> Get()
        {
            return Json(await GetData());
        }

        [NonAction]
        public async Task<ExchangeRatesResponse> GetData()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(ExternalApiUrl);
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ExchangeRatesResponse>(responseJson);
            }
        }
    }
}
