using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<YouTubePlaylistData> YouTubePlaylistAsync(string v)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/YouTubePlaylist/{_apiKey}/{v}";
                return await Utils.DownloadObjectAsync<YouTubePlaylistData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new YouTubePlaylistData() { ErrorMessage = ex.Message };
            }
        }
    }
}
