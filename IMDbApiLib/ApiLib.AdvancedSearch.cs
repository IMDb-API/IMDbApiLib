using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Performs an advanced search using the supplied filters and returns matching results.
    /// </summary>
    /// <param name="advancedSearchInput">The advanced search filters and options.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="AdvancedSearchData"/> object containing search results or an error message.</returns>
    public async Task<AdvancedSearchData?> AdvancedSearchAsync(AdvancedSearchInput advancedSearchInput, Language lang = Language.EN)
    {
        try
        {
            string queryString = advancedSearchInput.ToString();
            if (string.IsNullOrEmpty(queryString))
            {
                throw new Exception("It is mandatory to enter at least one filter.");
            }

            queryString += $"&apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            string url = $"{BaseUrl}/api/advanced-search{queryString}";
            return await GetObjectAsync<AdvancedSearchData>(url);
        }
        catch (Exception ex)
        {
            return new AdvancedSearchData() { ErrorMessage = ex.Message };
        }
    }
}