using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get available images for a movie or TV series using its IMDb ID. This endpoint returns image collections and related information for the requested title.
    /// </summary>
    /// <param name="id">IMDb identifier. The ID can be a title ID starting with "tt" or a person ID starting with "nm". Examples: "tt1375666", "nm0000154"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="ImageData"/> response containing the requested data or an error message.</returns>
    public async Task<ImageData?> ImagesAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/images?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ImageData>(url);
        }
        catch (Exception ex)
        {
            return new ImageData() { ErrorMessage = ex.Message };
        }
    }
}