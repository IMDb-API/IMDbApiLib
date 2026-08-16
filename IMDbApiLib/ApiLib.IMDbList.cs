using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves an IMDb list by identifier.
    /// </summary>
    /// <param name="id">The IMDb list identifier.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="IMDbListData"/> object containing the list or an error message.</returns>
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