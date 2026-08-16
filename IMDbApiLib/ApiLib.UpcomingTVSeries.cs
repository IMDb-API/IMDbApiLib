using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get upcoming TV series that are scheduled for release. This endpoint returns a list of future TV series releases with related information such as title details, release dates, ratings, and other available metadata.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="UpcomingData"/> response containing the requested data or an error message.</returns>
    public async Task<UpcomingData?> UpcomingTVSeriesAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/upcoming-tvseries?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<UpcomingData>(url);
        }
        catch (Exception ex)
        {
            return new UpcomingData() { ErrorMessage = ex.Message };
        }
    }
}