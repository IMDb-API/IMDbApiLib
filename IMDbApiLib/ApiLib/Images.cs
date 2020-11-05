using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        /// <summary>
        /// Download Images (ImageData)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="options">Short or Full</param>
        /// <returns></returns>
        public async Task<ImageData> ImagesAsync(string id, string options = "Short")
        {
            try
            {
                if (string.IsNullOrEmpty(options))
                    options = "Short";
                else
                    options = "/" + options;

                string url = $"{BaseUrl}/en/API/Images/{_apiKey}/{id}{options}";
                return await Utils.DownloadObjectAsync<ImageData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new ImageData() { ErrorMessage = ex.Message };
            }
        }
    }
}
