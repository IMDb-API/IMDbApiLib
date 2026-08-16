using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves keyword details for the specified keyword identifier.
    /// </summary>
    /// <param name="kwId">The keyword identifier.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="KeywordData"/> object containing keyword information or an error message.</returns>
    public async Task<KeywordData?> KeywordAsync(string kwId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/keyword?apiKey={Encode(_apiKey)}&id={Encode(kwId)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<KeywordData>(url);
        }
        catch (Exception ex)
        {
            return new KeywordData() { ErrorMessage = ex.Message };
        }
    }
}