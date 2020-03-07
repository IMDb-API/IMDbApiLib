namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public string BaseUrl => "https://imdb-api.com";

        private readonly string _apiKey;

        public ApiLib(string apiKey)
        {
            _apiKey = apiKey;
        }
    }
}
