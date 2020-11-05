using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<MostPopularData> MostPopularTVsAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/MostPopularTVs/{_apiKey}";
                return await Utils.DownloadObjectAsync<MostPopularData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new MostPopularData() { ErrorMessage = ex.Message };
            }
        }
    }
}
