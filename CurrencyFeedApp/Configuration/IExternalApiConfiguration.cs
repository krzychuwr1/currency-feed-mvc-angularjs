using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFeedApp.Configuration
{
    public interface IExternalApiConfiguration
    {
        string ExternalApiUrl { get; }
    }
}
