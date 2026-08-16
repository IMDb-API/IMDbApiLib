using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves reviews for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="ReviewData"/> object containing reviews or an error message.</returns>
    public async Task<ReviewData?> ReviewsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/reviews?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<ReviewData>(url);
        }
        catch (Exception ex)
        {
            return new ReviewData() { ErrorMessage = ex.Message };
        }
    }
}