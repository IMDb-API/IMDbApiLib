using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves external sites related to the specified title or person identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title or person.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="ExternalSiteData"/> object containing external site information or an error message.</returns>
    public async Task<ExternalSiteData?> ExternalSitesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/external-sites?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<ExternalSiteData>(url);
        }
        catch (Exception ex)
        {
            return new ExternalSiteData() { ErrorMessage = ex.Message };
        }
    }
}