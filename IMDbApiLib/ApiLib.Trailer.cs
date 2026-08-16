using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves trailer information for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="TrailerData"/> object containing trailer details or an error message.</returns>
    public async Task<TrailerData?> TrailerAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/trailer?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<TrailerData>(url);
        }
        catch (Exception ex)
        {
            return new TrailerData() { ErrorMessage = ex.Message };
        }
    }
}