using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<byte[]> ResizePosterAsync(string size, string url)
        {
            try
            {
                url = ResizePosterUrl(size, url);
                return await ApiUtils.GetBytesAsync(url, webProxy: WebProxy);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ResizePosterSaveFileAsync(string size, string url, string filePath)
        {
            try
            {
                url = ResizePosterUrl(size, url);
                await ApiUtils.SaveFileAsync(url, filePath, webProxy: WebProxy);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ResizePosterUrl(string size, string url)
        {
            try
            {
                url = $"{BaseUrl}/API/ResizePoster?apiKey={_apiKey}&size={size}&url={url}";
                return url;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}