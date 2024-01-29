using Microsoft.Extensions.Logging;
using RestSharp;

namespace Dneprokos.RestApi.Framework.Requests
{
    public abstract class ApiRequestBase
    {
        protected readonly RestClient? Client;
        protected readonly ILogger? Logger;

        protected readonly Dictionary<string, string> Headers = new()
        {
            { "accept", "application/json" },
            { "Content-Type", "application/json" }
        };

        protected ApiRequestBase(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }

        protected ApiRequestBase(string baseUrl, ILogger logger)
        {
            Client = new RestClient(baseUrl);
            Logger = logger;
        }
    }
}
