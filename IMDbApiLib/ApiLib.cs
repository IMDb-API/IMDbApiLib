using System.Net;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public string BaseUrl => "https://imdb-api.com";

        private readonly string _apiKey;
        private readonly WebProxy _webProxy;

        public ApiLib(string apiKey)
        {
            _apiKey = apiKey;
            _webProxy = null;
        }

        public ApiLib(string apiKey, WebProxy webProxy)
        {
            _apiKey = apiKey;
            _webProxy = webProxy;
        }
    }
}
