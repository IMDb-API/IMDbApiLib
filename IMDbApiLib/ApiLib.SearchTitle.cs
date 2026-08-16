using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches titles using the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or title text.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchTitleData"/> object containing title search results or an error message.</returns>
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