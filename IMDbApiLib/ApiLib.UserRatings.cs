using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get user rating information for a movie or TV series using its IMDb ID. This endpoint provides rating distribution data based on user votes, including the number of votes for each rating level.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="UserRatingData"/> response containing the requested data or an error message.</returns>
    public async Task<UserRatingData?> UserRatingsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/user-ratings?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<UserRatingData>(url);
        }
        catch (Exception ex)
        {
            return new UserRatingData() { ErrorMessage = ex.Message };
        }
    }
}