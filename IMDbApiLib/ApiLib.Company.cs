using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves company information for the specified company identifier.
    /// </summary>
    /// <param name="coId">The company identifier.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="CompanyData"/> object with company details or an error message.</returns>
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