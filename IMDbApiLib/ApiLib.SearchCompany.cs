using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for production companies, studios, and other entertainment-related companies. This endpoint allows you to find companies by name.
    /// </summary>
    /// <param name="expression">The search expression used to find companies. You can search by company name or partial name. Examples: "Warner Bros", "Disney", "ABC Studios".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchCompanyData"/> response containing the requested data or an error message.</returns>
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