using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves upcoming movies.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="UpcomingData"/> object containing upcoming movies or an error message.</returns>
    public async Task<UpcomingData?> UpcomingMoviesAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/upcoming-movies?apiKey={_apiKey}&lang={lang}".ToLower();
            return await GetObjectAsync<UpcomingData>(url);
        }
        catch (Exception ex)
        {
            return new UpcomingData() { ErrorMessage = ex.Message };
        }
    }
}