using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Searches TV episodes using the specified expression.
    /// </summary>
    /// <param name="expression">The search expression or episode title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="SearchEpisodeData"/> object containing TV episode search results or an error message.</returns>
    public async Task<SearchEpisodeData?> SearchTVEpisodeAsync(string expression, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/search-tvepisode?apiKey={Encode(_apiKey)}&expression={Encode(expression)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<SearchEpisodeData>(url);
        }
        catch (Exception ex)
        {
            return new SearchEpisodeData() { ErrorMessage = ex.Message };
        }
    }
}