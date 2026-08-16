using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get release information for a movie using its IMDb ID. This endpoint returns available release dates, countries, release types, and other related release details.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="ReleaseData"/> response containing the requested data or an error message.</returns>
    public async Task<ReleaseData?> ReleasesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/releases?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ReleaseData>(url);
        }
        catch (Exception ex)
        {
            return new ReleaseData() { ErrorMessage = ex.Message };
        }
    }
}