using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves award information for a person identified by name id.
    /// </summary>
    /// <param name="nmId">The name (person) identifier.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="NameAwardData"/> object with award details or an error message.</returns>
    public async Task<NameAwardData?> NameAwardsAsync(string nmId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/name-awards?apiKey={Encode(_apiKey)}&id={Encode(nmId)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<NameAwardData>(url);
        }
        catch (Exception ex)
        {
            return new NameAwardData() { ErrorMessage = ex.Message };
        }
    }
}