using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches companies by the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or company name.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchCompanyData"/> object containing company search results or an error message.</returns>
    public async Task<SearchCompanyData?> SearchCompanyAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-company?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchCompanyData>(url);
        }
        catch (Exception ex)
        {
            return new SearchCompanyData() { ErrorMessage = ex.Message };
        }
    }
}