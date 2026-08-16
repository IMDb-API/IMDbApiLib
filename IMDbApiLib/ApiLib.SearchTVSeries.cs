using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for TV series by title, or title name with release year. This endpoint is optimized for TV series searches and provides more accurate results compared to the general title search endpoint.
    /// </summary>
    /// <param name="expression">The search expression used to find TV series. You can search by series title, keywords, or include the release year to improve accuracy. Examples: "Lost", "Fringe", "The Leftovers 2014".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchTitleData"/> response containing the requested data or an error message.</returns>
    public async Task<SearchTitleData?> SearchTVSeriesAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-tvseries?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchTitleData>(url);
        }
        catch (Exception ex)
        {
            return new SearchTitleData() { ErrorMessage = ex.Message };
        }
    }
}