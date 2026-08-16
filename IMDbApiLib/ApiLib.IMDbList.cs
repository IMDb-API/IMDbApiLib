using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get IMDb lists by list identifier. This endpoint returns titles and related information from predefined IMDb lists such as popular movies, top rated titles, trending items, and other available collections.
    /// </summary>
    /// <param name="id">IMDb list identifier. The ID must be a valid IMDb list ID starting with "ls". Example: "ls123456789"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="IMDbListData"/> response containing the requested data or an error message.</returns>
    public async Task<IMDbListData?> IMDbListAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/imdb-list?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<IMDbListData>(url);
        }
        catch (Exception ex)
        {
            return new IMDbListData() { ErrorMessage = ex.Message };
        }
    }
}