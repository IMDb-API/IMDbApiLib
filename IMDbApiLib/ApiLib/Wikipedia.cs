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
                string url = $"{BaseUrl}/{language}/API/Wikipedia/{_apiKey}/{id}";
                return await ApiUtils.GetObjectAsync<WikipediaData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new WikipediaData() { ErrorMessage = ex.Message };
            }
        }
    }
}
