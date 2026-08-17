using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get movies and TV series associated with a specific keyword. This endpoint returns titles related to the requested keyword with available information such as title details, ratings, and other metadata.
    /// </summary>
    /// <param name="keyword">A valid keyword used to search for related movies and TV series. Example: "gun"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="KeywordData"/> response containing the requested data or an error message.</returns>
    public async Task<KeywordData?> KeywordAsync(string keyword, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/keyword?apiKey={Encode(_apiKey)}&id={Encode(keyword)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<KeywordData>(url);
        }
        catch (Exception ex)
        {
            return new KeywordData() { ErrorMessage = ex.Message };
        }
    }
}