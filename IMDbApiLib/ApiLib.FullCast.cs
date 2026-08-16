using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves full cast information for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="FullCastData"/> object containing cast and crew information or an error message.</returns>
    public async Task<FullCastData?> FullCastDataAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/fullcast?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<FullCastData>(url);
        }
        catch (Exception ex)
        {
            return new FullCastData() { ErrorMessage = ex.Message };
        }
    }
}