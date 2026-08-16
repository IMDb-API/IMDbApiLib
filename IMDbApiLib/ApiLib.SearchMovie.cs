using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for movies by title, or title name with release year. This endpoint is optimized for movie searches and provides more accurate results compared to the general title search endpoint.
    /// </summary>
    /// <param name="expression">The search expression used to find movies. You can search by movie title, keywords, or include the release year to improve accuracy. Examples: "Inception", "Leon The Professional", "Inception 2010".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchTitleData"/> response containing the requested data or an error message.</returns>
    public async Task<SearchTitleData?> SearchMovieAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-movie?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchTitleData>(url);
        }
        catch (Exception ex)
        {
            return new SearchTitleData() { ErrorMessage = ex.Message };
        }
    }
}