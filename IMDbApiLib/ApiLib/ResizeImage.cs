using IMDbApiLib.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<byte[]> ResizeImageBytesAsync(string size, string url)
        {
            try
            {
                url = $"{BaseUrl}/API/ResizeImage?apiKey={_apiKey}&size={size}&url={url}";
                return await Utils.DownloadDataAsync(url, webProxy: WebProxy);

            }
            catch
            {
                return null;
            }
        }
    }
}