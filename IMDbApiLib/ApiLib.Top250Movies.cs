using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves the top 250 movies.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="Top250Data"/> object with top 250 movies or an error message.</returns>
    public async Task<Top250Data?> Top250MoviesAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/top-250-movies?apiKey={_apiKey}&lang={lang}".ToLower();
            return await GetObjectAsync<Top250Data>(url);
        }
        catch (Exception ex)
        {
            return new Top250Data() { ErrorMessage = ex.Message };
        }
    }
}