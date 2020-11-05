using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<PosterData> PostersAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Posters/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<PosterData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new PosterData() { ErrorMessage = ex.Message };
            }
        }
    }
}
