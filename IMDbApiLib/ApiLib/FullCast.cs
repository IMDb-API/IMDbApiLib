using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<FullCastData> FullCastDataAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/FullCast/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<FullCastData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new FullCastData() { ErrorMessage = ex.Message };
            }
        }
    }
}
