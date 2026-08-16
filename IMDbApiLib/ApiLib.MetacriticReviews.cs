using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves Metacritic reviews for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="MetacriticReviewData"/> object containing reviews or an error message.</returns>
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