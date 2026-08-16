using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves the API report for a specific title or resource.
    /// </summary>
    /// <param name="id">The IMDb identifier of the title or resource to report on (for example, "tt0111161").</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="ReportData"/> object containing report information or an error message.</returns>
    public async Task<ReportData?> ReportAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/report?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ReportData>(url);
        }
        catch (Exception ex)
        {
            return new ReportData() { ErrorMessage = ex.Message };
        }
    }
}