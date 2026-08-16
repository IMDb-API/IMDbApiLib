using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get detailed information about a movie or TV series using its IMDb ID. The response includes basic title information, ratings, images, posters, trailers, actors, cast, and other available metadata based on selected options.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <param name="options">Options to include additional information in the response. You can select extra data sections such as "FullActor", "FullCast", "Posters", "Images", "Trailer", "Ratings", and "Wikipedia". Multiple options can be selected to customize the returned data.</param>
    /// <returns>The <see cref="TitleData"/> response containing the requested data or an error message.</returns>
    public async Task<TitleData?> TitleAsync(string id, Language lang = Language.EN, string? options = null)
    {
        try
        {
            string url = $"{BaseUrl}/api/title?apiKey={Encode(_apiKey)}&id={Encode(id)}&options={Encode(options)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<TitleData>(url);
        }
        catch (Exception ex)
        {
            return new TitleData() { ErrorMessage = ex.Message };
        }
    }
    /// <summary>
    /// Get detailed information about a movie or TV series using its IMDb ID. The response includes basic title information, ratings, images, posters, trailers, actors, cast, and other available metadata based on selected options.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="language">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <param name="FullActor">Whether to include the "FullActor" data section.</param>
    /// <param name="FullCast">Whether to include the "FullCast" data section.</param>
    /// <param name="Wikipedia">Whether to include the "Wikipedia" data section.</param>
    /// <param name="Posters">Whether to include the "Posters" data section.</param>
    /// <param name="Images">Whether to include the "Images" data section.</param>
    /// <param name="Trailer">Whether to include the "Trailer" data section.</param>
    /// <param name="Ratings">Whether to include the "Ratings" data section.</param>
    /// <returns>The <see cref="TitleData"/> response containing the requested data or an error message.</returns>
    public async Task<TitleData?> TitleAsync(string id, Language language = Language.EN, bool FullActor = false, bool FullCast = false, bool Wikipedia = false, bool Posters = false, bool Images = false, bool Trailer = false, bool Ratings = false)
    {
        string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, Posters, Images, Trailer, Ratings);
        return await TitleAsync(id, language, options);
    }
}