using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<YouTubeData> YouTubeAsync(string v)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/YouTube/{_apiKey}/{v}";
                return await Utils.DownloadObjectAsync<YouTubeData>(url);
            }
            catch (Exception ex)
            {
                return new YouTubeData() { ErrorMessage = ex.Message };
            }
        }
    }
}
