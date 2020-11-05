using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<IMDbListData> IMDbListAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/IMDbList/{_apiKey}/{id}";
                string json = await Utils.DownloadJsonAsync(url, _webProxy);
                return await Utils.DownloadObjectAsync<IMDbListData>(url);
            }
            catch (Exception ex)
            {
                return new IMDbListData() { ErrorMessage = ex.Message };
            }
        }
    }
}
