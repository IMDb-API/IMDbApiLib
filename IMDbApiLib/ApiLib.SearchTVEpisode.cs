using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for TV episodes by episode title, keywords, or other episode-related information. This endpoint allows you to find individual episodes from TV series.
    /// </summary>
    /// <param name="expression">The search expression used to find TV episodes. You can search by episode title, keywords, or other related terms. Examples: "london", "west", "gun".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchEpisodeData"/> response containing the requested data or an error message.</returns>
    public async Task<SearchEpisodeData?> SearchTVEpisodeAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-tvepisode?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchEpisodeData>(url);
        }
        catch (Exception ex)
        {
            return new SearchEpisodeData() { ErrorMessage = ex.Message };
        }
    }
}