using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<TrailerData> TrailerAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Trailer/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<TrailerData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new TrailerData() { ErrorMessage = ex.Message };
            }
        }
    }
}
