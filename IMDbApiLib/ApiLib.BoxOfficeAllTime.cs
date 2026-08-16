using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get all-time box office results. This endpoint returns the highest-grossing movies of all time with related information such as rankings, worldwide earnings, and movie details.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="BoxOfficeAllTimeData"/> response containing the requested data or an error message.</returns>
    public async Task<BoxOfficeAllTimeData?> BoxOfficeAllTimeAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/box-office-all-time?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<BoxOfficeAllTimeData>(url);
        }
        catch (Exception ex)
        {
            return new BoxOfficeAllTimeData() { ErrorMessage = ex.Message };
        }
    }
}