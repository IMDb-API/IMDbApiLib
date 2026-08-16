using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves episodes for a specific season of a title.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="seasonNumber">The season number to retrieve episodes for.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SeasonEpisodeData"/> object containing episode details or an error message.</returns>
    public async Task<SeasonEpisodeData?> SeasonEpisodesAsync(string id, int seasonNumber, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/season-episodes?apiKey={_apiKey}&id={id}&seasonNumber={seasonNumber}&lang={lang}".ToLower();
            return await GetObjectAsync<SeasonEpisodeData>(url);
        }
        catch (Exception ex)
        {
            return new SeasonEpisodeData() { ErrorMessage = ex.Message };
        }
    }
}