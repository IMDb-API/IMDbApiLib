using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves images for the specified title or person identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title or person.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="ImageData"/> object containing images or an error message.</returns>
    public async Task<ImageData?> ImagesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/images?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<ImageData>(url);
        }
        catch (Exception ex)
        {
            return new ImageData() { ErrorMessage = ex.Message };
        }
    }
}