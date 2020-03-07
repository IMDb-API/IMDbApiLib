using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<SeasonEpisodeData> SeasonEpisodesAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/SeasonEpisodes/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<SeasonEpisodeData>(url);
            }
            catch (Exception ex)
            {
                return new SeasonEpisodeData() { ErrorMessage = ex.Message };
            }
        }
    }
}
