using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get the top 100 most popular movies based on IMDb popularity rankings. This endpoint returns a list of currently popular movies with related information such as title details, ratings, and popularity data.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="MostPopularData"/> response containing the requested data or an error message.</returns>
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