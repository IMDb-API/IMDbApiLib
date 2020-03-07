using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<WikipediaData> WikipediaAsync(string id, Language language)
        {
            try
            {
                string url = $"{BaseUrl}/{language.ToString()}/API/Wikipedia/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<WikipediaData>(url);
            }
            catch (Exception ex)
            {
                return new WikipediaData() { ErrorMessage = ex.Message };
            }
        }
    }
}
