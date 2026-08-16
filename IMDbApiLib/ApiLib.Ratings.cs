using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get rating information for a movie or TV series using its IMDb ID. This endpoint returns available ratings from IMDb and other supported rating sources.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="RatingData"/> response containing the requested data or an error message.</returns>
    public async Task<RatingData?> RatingsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/ratings?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<RatingData>(url);
        }
        catch (Exception ex)
        {
            return new RatingData() { ErrorMessage = ex.Message };
        }
    }
}