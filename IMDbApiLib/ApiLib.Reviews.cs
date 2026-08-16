using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get user reviews for a movie or TV series using its IMDb ID. This endpoint returns available user reviews, ratings, review content, and related review details for the requested title.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="ReviewData"/> response containing the requested data or an error message.</returns>
    public async Task<ReviewData?> ReviewsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/reviews?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ReviewData>(url);
        }
        catch (Exception ex)
        {
            return new ReviewData() { ErrorMessage = ex.Message };
        }
    }
}