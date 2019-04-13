using CurrencyFeedApp.Models;
using CurrencyFeedApp.Services;
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
        private ICurrencyDataService _currencyDataService;

        public CurrencyDataController(ICurrencyDataService currencyDataService)
        {
            _currencyDataService = currencyDataService;
        }

        [HttpGet]
        public async Task<JsonResult<ExchangeRatesResponse>> Get()
        {
            return Json(await _currencyDataService.GetData());
        }
    }
}
