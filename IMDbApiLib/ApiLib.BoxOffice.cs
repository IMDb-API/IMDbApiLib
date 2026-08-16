using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get weekend box office results. This endpoint returns movie box office performance data including rankings, earnings, and related movie information.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="BoxOfficeWeekendData"/> response containing the requested data or an error message.</returns>
    public async Task<BoxOfficeWeekendData?> BoxOfficeAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/box-office?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<BoxOfficeWeekendData>(url);
        }
        catch (Exception ex)
        {
            return new BoxOfficeWeekendData() { ErrorMessage = ex.Message };
        }
    }
}