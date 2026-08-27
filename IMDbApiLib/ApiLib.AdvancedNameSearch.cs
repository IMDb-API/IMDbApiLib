using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches IMDb names using filters such as name, dates, awards, page topics, gender identity, and credits.
    /// </summary>
    /// <param name="advancedNameSearchInput">The filters to apply to the IMDb name search.</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="AdvancedNameSearchData"/> response containing matching people or an error message.</returns>
    public async Task<AdvancedNameSearchData?> AdvancedNameSearchAsync(AdvancedNameSearchInput advancedNameSearchInput, Language lang = Language.EN)
    {
        try
        {
            string queryString = advancedNameSearchInput.ToString();
            if (string.IsNullOrEmpty(queryString))
            {
                return new AdvancedNameSearchData()
                {
                    ErrorMessage = "It is mandatory to enter at least one filter."
                };
            }

            queryString += $"&apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            string url = $"{BaseUrl}/api/advanced-name-search{queryString}";
            return await GetObjectAsync<AdvancedNameSearchData>(url);
        }
        catch (Exception ex)
        {
            return new AdvancedNameSearchData() { ErrorMessage = ex.Message };
        }
    }
}