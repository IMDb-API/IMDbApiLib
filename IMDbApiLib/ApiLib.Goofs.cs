using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves goofs (mistakes) for a title identified by its IMDb id.
    /// </summary>
    /// <param name="id">The IMDb title identifier (for example, "tt0111161").</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="GoofData"/> object containing goofs or an error message.</returns>
    public async Task<GoofData?> GoofsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/goofs?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<GoofData>(url);
        }
        catch (Exception ex)
        {
            return new GoofData() { ErrorMessage = ex.Message };
        }
    }
}