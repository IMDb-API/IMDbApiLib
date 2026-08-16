using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves user rating data for the specified title identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>A <see cref="UserRatingData"/> object containing user rating details or an error message.</returns>
    public async Task<UserRatingData?> UserRatingAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/user-ratings?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<UserRatingData>(url);
        }
        catch (Exception ex)
        {
            return new UserRatingData() { ErrorMessage = ex.Message };
        }
    }
}