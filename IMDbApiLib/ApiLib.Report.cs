using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Generate a detailed "HTML" report for a movie or TV series using its IMDb ID. The report can include title information, actors, cast, posters, images, trailers, ratings, and Wikipedia content based on the selected options.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <param name="options">Options to include additional information in the response. You can select extra data sections such as "FullActor", "FullCast", "Posters", "Images", "Trailer", "Ratings", and "Wikipedia". Multiple options can be selected to customize the returned data.</param>
    /// <returns>The <see cref="ReportData"/> response containing the requested data or an error message.</returns>
    public async Task<ReportData?> ReportAsync(string id, Language lang = Language.EN, string? options = null)
    {
        try
        {
            string url = $"{BaseUrl}/api/report?apiKey={Encode(_apiKey)}&id={Encode(id)}&options={Encode(options)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<ReportData>(url);
        }
        catch (Exception ex)
        {
            return new ReportData() { ErrorMessage = ex.Message };
        }
    }
}