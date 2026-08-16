using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get Metacritic reviews for a movie or TV series using its IMDb ID. This endpoint returns available critic reviews, scores, and related review information from Metacritic.
    /// </summary>
    /// <param name="id">IMDb movie ID. This service only supports movies. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="MetacriticReviewData"/> response containing the requested data or an error message.</returns>
    public async Task<MetacriticReviewData?> MetacriticReviewsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/metacritic-reviews?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<MetacriticReviewData>(url);
        }
        catch (Exception ex)
        {
            return new MetacriticReviewData() { ErrorMessage = ex.Message };
        }
    }
}