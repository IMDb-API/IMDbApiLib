using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves information about a person by name identifier.
    /// </summary>
    /// <param name="nmId">The name (person) identifier.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="NameData"/> object with person details or an error message.</returns>
    public async Task<NameData?> NameAsync(string nmId, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/name?apiKey={_apiKey}&id={nmId}&lang={lang}".ToLower();
            return await GetObjectAsync<NameData>(url);
        }
        catch (Exception ex)
        {
            return new NameData() { ErrorMessage = ex.Message };
        }
    }
}