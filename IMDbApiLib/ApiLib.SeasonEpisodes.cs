using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get all episodes of a specific season for a TV series using its IMDb ID. This endpoint returns episode information including episode titles, numbers, release dates, ratings, and other available details.
    /// </summary>
    /// <param name="id">IMDb title ID of the TV series. The ID must be a valid IMDb identifier starting with "tt". Example: "tt0411008"</param>
    /// <param name="seasonNumber">The season number to retrieve episodes from. Example: "1"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SeasonEpisodeData"/> response containing the requested data or an error message.</returns>
    public async Task<SeasonEpisodeData?> SeasonEpisodesAsync(string id, int seasonNumber, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/season-episodes?apiKey={Encode(_apiKey)}&id={Encode(id)}&seasonNumber={seasonNumber}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SeasonEpisodeData>(url);
        }
        catch (Exception ex)
        {
            return new SeasonEpisodeData() { ErrorMessage = ex.Message };
        }
    }
}