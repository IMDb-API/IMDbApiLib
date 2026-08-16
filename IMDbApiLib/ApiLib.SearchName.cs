using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for people including actors, actresses, directors, writers, and other industry professionals. This endpoint allows you to find people by name.
    /// </summary>
    /// <param name="expression">The search expression used to find people. You can search by a person's full name or partial name. Examples: "Jean Reno", "Mel Gibson", "Natalie Portman".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchNameData"/> response containing the requested data or an error message.</returns>
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