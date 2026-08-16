using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves YouTube trailer information for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="YouTubeTrailerData"/> object containing YouTube trailer details or an error message.</returns>
    public async Task<YouTubeTrailerData?> YouTubeTrailerAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/youtube-trailer?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<YouTubeTrailerData>(url);
        }
        catch (Exception ex)
        {
            return new YouTubeTrailerData() { ErrorMessage = ex.Message };
        }
    }
}