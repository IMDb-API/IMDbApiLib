using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves movies currently in theaters.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="InTheaterData"/> object with in-theater movies or an error message.</returns>
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