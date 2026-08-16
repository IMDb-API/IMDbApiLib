using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get detailed information about a company and its associated movies. This endpoint returns company details along with related titles produced, distributed, or associated with the company.
    /// </summary>
    /// <param name="coId">IMDb company ID. The ID must be a valid IMDb company identifier. Example: "co0002663"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="CompanyData"/> response containing the requested data or an error message.</returns>
    public async Task<CompanyData?> CompanyAsync(string coId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/company?apiKey={Encode(_apiKey)}&id={Encode(coId)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<CompanyData>(url);
        }
        catch (Exception ex)
        {
            return new CompanyData() { ErrorMessage = ex.Message };
        }
    }
}