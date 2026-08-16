using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search across all available items including movies, TV series, TV episodes, people, companies, keywords, and other supported data types. This endpoint is useful when you do not know the exact item type you are looking for.
    /// </summary>
    /// <param name="expression">The search expression used to find items across all supported data types. You can search by title, name, company, keyword, or other related terms. Examples: "Inception", "Leon", "Lost".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchData"/> response containing the requested data or an error message.</returns>
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