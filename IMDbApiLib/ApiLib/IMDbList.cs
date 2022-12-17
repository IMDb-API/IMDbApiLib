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
                return await Utils.DownloadObjectAsync<IMDbListData>(url);
            }
            catch (Exception ex)
            {
                return new IMDbListData() { ErrorMessage = ex.Message };
            }
        }
    }
}
