using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches TV series using the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or series title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchData"/> object containing TV series search results or an error message.</returns>
    public async Task<SearchData?> SearchTVSeriesAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-tvseries?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchData>(url);
        }
        catch (Exception ex)
        {
            return new SearchData() { ErrorMessage = ex.Message };
        }
    }
}