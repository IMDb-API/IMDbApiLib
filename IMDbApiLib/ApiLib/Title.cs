using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {

        /// <summary>
        /// Get TileData
        /// </summary>
        /// <param name="id">A valid IMDb Id (start withs tt)</param>
        /// /// <param name="language">IMDbApiLib.Models.Language enum</param>
        /// <param name="options">FullActor,FullCast,Wikipedia,Posters,Images,Trailer,Ratings</param>
        /// <returns>TitleData</returns>
        public async Task<TitleData> TitleAsync(string id, Language language, string options)
        {
            try
            {
                if (string.IsNullOrEmpty(options))
                    options = string.Empty;
                else
                    options = "/" + options;

                string url = $"{BaseUrl}/{language.ToString()}/API/Title/{_apiKey}/{id}{options}";
                return await Utils.DownloadObjectAsync<TitleData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new TitleData() { ErrorMessage = ex.Message };
            }
        }

        /// <summary>
        /// Get TileData
        /// </summary>
        /// <param name="id">A valid IMDb Id (start withs tt)</param>
        /// <param name="language">IMDbApiLib.Models.Language enum</param>
        /// <param name="options">FullActor,FullCast,Wikipedia,Posters,Images,Trailer,Ratings</param>
        /// <returns>TitleData</returns>
        public async Task<TitleData> TitleAsync(string id, Language language = Language.en, bool FullActor = false, bool FullCast = false, bool Wikipedia = false, bool Posters = false, bool Images = false, bool Trailer = false, bool Ratings = false)
        {
            string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, Posters, Images, Trailer, Ratings);
            return await TitleAsync(id, language, options);
        }

        /// <summary>
        /// Get TileData
        /// </summary>
        /// <param name="id">A valid IMDb Id (start withs tt)</param>
        /// <returns></returns>
        public async Task<TitleData> TitleAsync(string id)
        {
            return await TitleAsync(id, Language.en, null);
        }

        /// <summary>
        /// Get TileData
        /// </summary>
        /// <param name="id">A valid IMDb Id (start withs tt)</param>
        /// /// <param name="language">IMDbApiLib.Models.Language enum</param>
        /// <param name="options">FullActor,FullCast,Wikipedia,Posters,Images,Trailer,Ratings</param>
        /// <returns>TitleData</returns>
        public async Task<TitleData> TitleAsync(string id, Language language)
        {
            return await TitleAsync(id, language, null);
        }
    }
}
