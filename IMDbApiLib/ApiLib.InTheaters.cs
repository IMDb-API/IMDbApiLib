using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get movies currently available in theaters. This endpoint returns a list of movies that are currently playing in cinemas with related information such as title details, release information, ratings, and other available metadata.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="InTheaterData"/> response containing the requested data or an error message.</returns>
    public async Task<InTheaterData?> InTheatersAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/in-theaters?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<InTheaterData>(url);
        }
        catch (Exception ex)
        {
            return new InTheaterData() { ErrorMessage = ex.Message };
        }
    }
}