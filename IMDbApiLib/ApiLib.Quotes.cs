using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get memorable quotes and dialogue from a movie or TV series using its IMDb ID. This endpoint returns available quotes, dialogue, and related quote details for the requested title.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="QuoteData"/> response containing the requested data or an error message.</returns>
    public async Task<QuoteData?> QuotesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/quotes?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<QuoteData>(url);
        }
        catch (Exception ex)
        {
            return new QuoteData() { ErrorMessage = ex.Message };
        }
    }
}