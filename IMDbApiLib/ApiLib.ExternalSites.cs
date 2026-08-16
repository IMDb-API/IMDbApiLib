using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get external website links related to a movie, TV series, or person using its IMDb ID. This endpoint returns available links to external platforms and official pages associated with the requested item.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="ExternalSiteData"/> response containing the requested data or an error message.</returns>
    public async Task<ExternalSiteData?> ExternalSitesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/external-sites?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ExternalSiteData>(url);
        }
        catch (Exception ex)
        {
            return new ExternalSiteData() { ErrorMessage = ex.Message };
        }
    }
}