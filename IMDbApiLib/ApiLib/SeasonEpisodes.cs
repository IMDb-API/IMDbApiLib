using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<SeasonEpisodeData> SeasonEpisodesAsync(string id, int seasonNumber)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/SeasonEpisodes/{_apiKey}/{id}/{seasonNumber}";
                return await Utils.DownloadObjectAsync<SeasonEpisodeData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new SeasonEpisodeData() { ErrorMessage = ex.Message };
            }
        }
    }
}
