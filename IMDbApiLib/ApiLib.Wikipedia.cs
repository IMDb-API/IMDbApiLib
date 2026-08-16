using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get Wikipedia information for a movie, or TV seriesusing its IMDb ID. This endpoint returns available Wikipedia details including summaries and related information in the selected language.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English).</param>
    /// <returns>The <see cref="WikipediaData"/> response containing the requested data or an error message.</returns>
    public async Task<WikipediaData?> WikipediaAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/wikipedia?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<WikipediaData>(url);
        }
        catch (Exception ex)
        {
            return new WikipediaData() { ErrorMessage = ex.Message };
        }
    }
}