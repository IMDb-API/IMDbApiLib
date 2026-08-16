using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get upcoming TV episodes that are scheduled for release. This endpoint returns a list of future TV episodes with related information such as episode details, release dates, ratings, and associated TV series information.
    /// </summary>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="UpcomingData"/> response containing the requested data or an error message.</returns>
    public async Task<UpcomingData?> UpcomingTVEpisodesAsync(Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/upcoming-tvepisodes?apiKey={Encode(_apiKey)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<UpcomingData>(url);
        }
        catch (Exception ex)
        {
            return new UpcomingData() { ErrorMessage = ex.Message };
        }
    }
}