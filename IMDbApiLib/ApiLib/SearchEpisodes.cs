using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<SearchData> SearchEpisodesAsync(string expression)
        {
            try
            {
                expression = PrepareExpression(expression);
                string url = $"{BaseUrl}/en/API/SearchEpisodes/{_apiKey}/{expression}";
                return await Utils.DownloadObjectAsync<SearchData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new SearchData() { ErrorMessage = ex.Message };
            }
        }
    }
}
