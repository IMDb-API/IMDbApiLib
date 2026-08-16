using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get awards information for a person using their IMDb ID. This endpoint returns available awards, nominations, wins, and related recognition details for actors, actresses, directors, writers, and other professionals.
    /// </summary>
    /// <param name="nmId">IMDb person ID. The ID must be a valid IMDb identifier starting with "nm". Example: "nm0000154"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="NameAwardData"/> response containing the requested data or an error message.</returns>
    public async Task<NameAwardData?> NameAwardsAsync(string nmId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/name-awards?apiKey={Encode(_apiKey)}&id={Encode(nmId)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<NameAwardData>(url);
        }
        catch (Exception ex)
        {
            return new NameAwardData() { ErrorMessage = ex.Message };
        }
    }
}