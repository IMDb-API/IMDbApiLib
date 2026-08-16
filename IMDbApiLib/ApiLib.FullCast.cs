using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get the complete cast and crew information for a movie or TV series using its IMDb ID. This endpoint provides detailed information about actors, directors, writers, and other crew members associated with the title.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="FullCastData"/> response containing the requested data or an error message.</returns>
    public async Task<FullCastData?> FullCastAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/fullcast?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<FullCastData>(url);
        }
        catch (Exception ex)
        {
            return new FullCastData() { ErrorMessage = ex.Message };
        }
    }
}