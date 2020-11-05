using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<YouTubeTrailerData> YouTubeTrailerAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/YouTubeTrailer/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<YouTubeTrailerData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new YouTubeTrailerData() { ErrorMessage = ex.Message };
            }
        }
    }
}
