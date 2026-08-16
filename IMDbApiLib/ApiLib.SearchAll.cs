using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches across movies, TV shows, names, and other categories using the given expression.
    /// </summary>
    /// <param name="expression">The search expression or query string.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchData"/> object containing search results or an error message.</returns>
    public async Task<SearchData?> SearchAllAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-all?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchData>(url);
        }
        catch (Exception ex)
        {
            return new SearchData() { ErrorMessage = ex.Message };
        }
    }
}