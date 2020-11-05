using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<Top250Data> Top250TVsAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Top250TVs/{_apiKey}";
                return await Utils.DownloadObjectAsync<Top250Data>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new Top250Data() { ErrorMessage = ex.Message };
            }
        }
    }
}
