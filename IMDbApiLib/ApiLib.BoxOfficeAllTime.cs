using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves all-time box office data.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="BoxOfficeAllTimeData"/> object with all-time box office information or an error message.</returns>
    public async Task<BoxOfficeAllTimeData?> BoxOfficeAllTimeAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/box-office-all-time?apiKey={_apiKey}&lang={lang}".ToLower();
            return await GetObjectAsync<BoxOfficeAllTimeData>(url);
        }
        catch (Exception ex)
        {
            return new BoxOfficeAllTimeData() { ErrorMessage = ex.Message };
        }
    }
}