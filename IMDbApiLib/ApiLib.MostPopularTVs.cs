using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves the most popular TV shows.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="MostPopularData"/> object with popular TV shows or an error message.</returns>
    public async Task<MostPopularData?> MostPopularTVsAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/most-popular-tvs?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<MostPopularData>(url);
        }
        catch (Exception ex)
        {
            return new MostPopularData() { ErrorMessage = ex.Message };
        }
    }
}