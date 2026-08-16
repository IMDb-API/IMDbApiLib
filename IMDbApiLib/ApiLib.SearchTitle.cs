using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search across all available titles including movies, TV series, episodes, and other title types. This endpoint is useful when you are not sure about the title type. For more accurate results, use "Search-Movie" for movies and "Search-TVSeries" for TV series when the title type is known.
    /// </summary>
    /// <param name="expression">The search expression used to find titles. You can search by title name, keywords, or title name with release year to improve accuracy. Examples: "Leon The Professional", "Inception", "Inception 2010". Including the release year is recommended when multiple titles have similar names.</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchTitleData"/> response containing the requested data or an error message.</returns>
    public async Task<SearchTitleData?> SearchTitleAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-title?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchTitleData>(url);
        }
        catch (Exception ex)
        {
            return new SearchTitleData() { ErrorMessage = ex.Message };
        }
    }
}