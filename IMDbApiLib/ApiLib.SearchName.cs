using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches names (people) using the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or person name.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchData"/> object containing name search results or an error message.</returns>
    public async Task<SearchData?> SearchNameAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-name?apiKey={_apiKey}&expression={expression}&lang={lang}".ToLower();
            return await GetObjectAsync<SearchData>(url);
        }
        catch (Exception ex)
        {
            return new SearchData() { ErrorMessage = ex.Message };
        }
    }
}