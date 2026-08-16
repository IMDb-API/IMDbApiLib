using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves upcoming TV episodes.
    /// </summary>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="UpcomingData"/> object containing upcoming TV episodes or an error message.</returns>
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