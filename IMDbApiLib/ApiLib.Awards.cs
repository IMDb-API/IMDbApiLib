using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves award information for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="AwardData"/> object containing award details or an error message.</returns>
    public async Task<AwardData?> AwardsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/awards?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<AwardData>(url);
        }
        catch (Exception ex)
        {
            return new AwardData() { ErrorMessage = ex.Message };
        }
    }
}