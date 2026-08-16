using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get the YouTube trailer URL of a movie or TV series using its IMDb ID. This endpoint returns the available trailer link from YouTube for the requested title.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="YouTubeTrailerData"/> response containing the requested data or an error message.</returns>
    public async Task<YouTubeTrailerData?> YouTubeTrailerAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/youtube-trailer?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<YouTubeTrailerData>(url);
        }
        catch (Exception ex)
        {
            return new YouTubeTrailerData() { ErrorMessage = ex.Message };
        }
    }
}