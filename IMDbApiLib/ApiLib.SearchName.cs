using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches names (people) using the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or person name.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchNameData"/> object containing name search results or an error message.</returns>
    public async Task<SearchNameData?> SearchNameAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-name?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchNameData>(url);
        }
        catch (Exception ex)
        {
            return new SearchNameData() { ErrorMessage = ex.Message };
        }
    }
}