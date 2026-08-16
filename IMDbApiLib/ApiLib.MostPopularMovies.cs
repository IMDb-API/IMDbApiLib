using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves the most popular movies.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="MostPopularData"/> object with popular movies or an error message.</returns>
    public async Task<MostPopularData?> MostPopularMoviesAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/most-popular-movies?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<MostPopularData>(url);
        }
        catch (Exception ex)
        {
            return new MostPopularData() { ErrorMessage = ex.Message };
        }
    }
}