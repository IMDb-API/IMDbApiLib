using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get detailed information about people in the entertainment industry such as actors, actresses, directors, writers, and other professionals using their IMDb ID. This endpoint returns available personal details and related information.
    /// </summary>
    /// <param name="nmId">IMDb person ID. The ID must be a valid IMDb identifier starting with "nm". Example: "nm0000154"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="NameData"/> response containing the requested data or an error message.</returns>
    public async Task<NameData?> NameAsync(string nmId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/name?apiKey={Encode(_apiKey)}&id={Encode(nmId)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<NameData>(url);
        }
        catch (Exception ex)
        {
            return new NameData() { ErrorMessage = ex.Message };
        }
    }
}