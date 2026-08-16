using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves Wikipedia content for the specified title or person identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title or person.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="WikipediaData"/> object containing Wikipedia content or an error message.</returns>
    public async Task<WikipediaData?> WikipediaAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/wikipedia?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<WikipediaData>(url);
        }
        catch (Exception ex)
        {
            return new WikipediaData() { ErrorMessage = ex.Message };
        }
    }
}