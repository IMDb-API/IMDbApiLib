using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Search for keywords used to categorize movies, TV series, and episodes. This endpoint allows you to find available keywords by name.
    /// </summary>
    /// <param name="expression">The search expression used to find keywords. You can search by keyword name or related terms. Examples: "gun", "battle", "love".</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="SearchKeywordData"/> response containing the requested data or an error message.</returns>
    public async Task<SearchKeywordData?> SearchKeywordAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-keyword?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchKeywordData>(url);
        }
        catch (Exception ex)
        {
            return new SearchKeywordData() { ErrorMessage = ex.Message };
        }
    }
}