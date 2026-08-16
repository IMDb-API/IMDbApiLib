using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves poster images for the specified title or person identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title or person.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="PosterData"/> object containing poster images or an error message.</returns>
    public async Task<PosterData?> PostersAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/posters?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<PosterData>(url);
        }
        catch (Exception ex)
        {
            return new PosterData() { ErrorMessage = ex.Message };
        }
    }
}