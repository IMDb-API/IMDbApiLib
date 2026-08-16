using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves release information for a movie by its IMDb identifier.
    /// </summary>
    /// <param name="id">A valid IMDb title identifier that starts with "tt".</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="ReleaseData"/> object containing release details or an error message.</returns>
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