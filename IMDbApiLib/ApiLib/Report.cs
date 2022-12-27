using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task ReportSaveFileAsync(string id, string filePath, Language language = Language.en, string options = "")
        {
            try
            {
                string url = ReportUrl(id, language, options);
                await ApiUtils.SaveFileAsync(url, filePath, WebProxy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ReportSaveFileAsync(string id, string filePath, Language language, bool FullActor, bool FullCast, bool Wikipedia, bool Ratings)
        {
            try
            {
                string url = ReportUrl(id, language, FullActor, FullCast, Wikipedia, Ratings);
                await ApiUtils.SaveFileAsync(url, filePath, WebProxy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<byte[]> ReportAsync(string id, Language language = Language.en, string options = "")
        {
            try
            {
                string url = ReportUrl(id, language, options);
                return await ApiUtils.GetBytesAsync(url, WebProxy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<byte[]> ReportAsync(string id, Language language, bool FullActor, bool FullCast, bool Wikipedia, bool Ratings)
        {
            try
            {
                string url = ReportUrl(id, language, FullActor, FullCast, Wikipedia, Ratings);
                return await ApiUtils.GetBytesAsync(url, WebProxy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReportUrl(string id, Language language = Language.en, string options = "")
        {
            if (string.IsNullOrEmpty(options))
                options = string.Empty;
            else
                options = "/" + options;

            string url = $"{BaseUrl}/{language}/API/Report/{_apiKey}/{id}{options}";
            return url;
        }

        public string ReportUrl(string id, Language language, bool FullActor, bool FullCast, bool Wikipedia, bool Ratings)
        {
            string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, false, false, false, Ratings);
            return ReportUrl(id, language, options);
        }
    }
}