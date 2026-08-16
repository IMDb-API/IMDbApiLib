using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Advanced search across all IMDb items including Movies, TV Series, TV Episodes, Names, Companies, Keywords, and more. Supports multiple filters to narrow down results based on title type, rating, genres, release dates, credits, and additional metadata.
    /// </summary>
    /// <param name="advancedSearchInput">Advanced search across all IMDb items including Movies, TV Series, TV Episodes, Names, Companies, Keywords, and more. Supports multiple filters to narrow down results based on title type, rating, genres, release dates, credits, and additional metadata.</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="AdvancedSearchData"/> response containing the requested data or an error message.</returns>
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