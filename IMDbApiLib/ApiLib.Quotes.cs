using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves quotes for a title identified by its IMDb id.
    /// </summary>
    /// <param name="id">The IMDb title identifier (for example, "tt0111161").</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="QuoteData"/> object containing quotes or an error message.</returns>
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