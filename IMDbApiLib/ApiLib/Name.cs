using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<NameData> NameAsync(string nmId)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Name/{_apiKey}/{nmId}";
                return await Utils.DownloadObjectAsync<NameData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new NameData() { ErrorMessage = ex.Message };
            }
        }
    }
}
