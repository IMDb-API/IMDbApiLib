using IMDbApiLib.Models;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {

        /// <summary>
        /// Download Report as PNG file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="id"></param>
        /// <param name="options">FullCast,FullActor,Wikipedia</param>
        /// <returns></returns>

        public async Task DownloadReportAsync(string id, string filePath, Language language = Language.en, string options = "")
        {
            try
            {
                if (string.IsNullOrEmpty(options))
                    options = string.Empty;
                else
                    options = "/" + options;

                string url = $"{BaseUrl}/{language}/API/Report/{_apiKey}/{id}{options}";
                using (var client = new WebClient())
                {
                    if (WebProxy != null)
                        client.Proxy = WebProxy;
                    await client.DownloadFileTaskAsync(url, filePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Download Report as PNG file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="id"></param>
        /// <param name="options">FullCast,FullActor,Wikipedia</param>
        /// <returns></returns>
        public async Task DownloadReportAsync(string id, string filePath, Language language = Language.en, bool FullActor = false, bool FullCast = false, bool Wikipedia = false, bool Ratings = false)
        {
            try
            {
                string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, false, false, false, Ratings);
                await DownloadReportAsync(id, filePath, language, options);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<byte[]> ReportBytesAsync(string id, Language language = Language.en, string options = "")
        {
            try
            {
                if (string.IsNullOrEmpty(options))
                    options = string.Empty;
                else
                    options = "/" + options;

                string url = $"{BaseUrl}/{language}/API/Report/{_apiKey}/{id}{options}";
                using (var client = new WebClient())
                {
                    if (WebProxy != null)
                        client.Proxy = WebProxy;

                    var bytes = await client.DownloadDataTaskAsync(url);
                    return bytes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<byte[]> ReportBytesAsync(string id, Language language, bool FullActor = false, bool FullCast = false, bool Wikipedia = false, bool Ratings = false)
        {
            try
            {
                string options = Options.OptionsToString(FullActor, FullCast, Wikipedia, false, false, false, Ratings);
                return await ReportBytesAsync(id, language, options);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DownloadReportAsync(string id, string filePath, Language language, string options, ProgressData progress = null, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(options))
                options = string.Empty;
            else
                options = "/" + options;

            string url = $"{BaseUrl}/{language.ToString()}/API/Report/{_apiKey}/{id}{options}";
            await Utils.DownloadFileAsync(filePath, url, progress, WebProxy);
        }
    }
}