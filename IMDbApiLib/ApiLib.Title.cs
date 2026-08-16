using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves detailed information for a title by its IMDb identifier.
    /// Use the <paramref name="options"/> parameter to request additional related data such as cast, images, trailers, and ratings.
    /// </summary>
    /// <param name="id">A valid IMDb identifier (starts with "tt").</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <param name="options">A comma-separated list of optional data to include: FullActor, FullCast, Wikipedia, Posters, Images, Trailer, Ratings.</param>
    /// <returns>A <see cref="TitleData"/> object containing title details or an error message.</returns>
    public async Task<TitleData?> TitleAsync(string id, Language lang = Language.EN, string? options = null)
    {
        try
        {
            string url = $"{BaseUrl}/api/title?apiKey={_apiKey}&id={id}&options={options}&lang={lang}".ToLower();
            return await GetObjectAsync<TitleData>(url);
        }
        catch (Exception ex)
        {
            return new TitleData() { ErrorMessage = ex.Message };
        }
    }

    /// <summary>
    /// Retrieves detailed information for a title by its IMDb identifier using boolean flags to request optional data.
    /// </summary>
    /// <param name="id">A valid IMDb identifier (starts with "tt").</param>
    /// <param name="language">The language for returned data (default is English).</param>
    /// <param name="FullActor">Include full actor details when true.</param>
    /// <param name="FullCast">Include full cast details when true.</param>
    /// <param name="Wikipedia">Include Wikipedia content when true.</param>
    /// <param name="Posters">Include posters when true.</param>
    /// <param name="Images">Include images when true.</param>
    /// <param name="Trailer">Include trailer information when true.</param>
    /// <param name="Ratings">Include ratings when true.</param>
    /// <returns>A <see cref="TitleData"/> object containing title details or an error message.</returns>
    public async Task<TitleData?> TitleAsync(string id, Language language = Language.EN, bool FullActor = false, bool FullCast = false, bool Wikipedia = false, bool Posters = false, bool Images = false, bool Trailer = false, bool Ratings = false)
    {
        string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, Posters, Images, Trailer, Ratings);
        return await TitleAsync(id, language, options);
    }
}