using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves ratings information for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="RatingData"/> object containing rating details or an error message.</returns>
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