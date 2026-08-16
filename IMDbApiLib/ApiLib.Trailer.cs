using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get trailer information for a movie or TV series using its IMDb ID. This endpoint returns available trailer videos and related metadata for the requested title.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="TrailerData"/> response containing the requested data or an error message.</returns>
    public async Task<TrailerData?> TrailerAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/trailer?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<TrailerData>(url);
        }
        catch (Exception ex)
        {
            return new TrailerData() { ErrorMessage = ex.Message };
        }
    }
}