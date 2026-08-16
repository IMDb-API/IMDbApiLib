using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get the top 250 TV series ranked by IMDb users. This endpoint returns a list of the highest-rated TV series with related information such as title details, ratings, and rankings.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="Top250Data"/> response containing the requested data or an error message.</returns>
    public async Task<Top250Data?> Top250TVsAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/top-250-tvs?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<Top250Data>(url);
        }
        catch (Exception ex)
        {
            return new Top250Data() { ErrorMessage = ex.Message };
        }
    }
}