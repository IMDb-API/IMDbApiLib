using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves box office weekend data.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="BoxOfficeWeekendData"/> object with box office information or an error message.</returns>
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