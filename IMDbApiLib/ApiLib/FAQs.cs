using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<FAQData> FAQsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/FAQs/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<FAQData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new FAQData() { ErrorMessage = ex.Message };
            }
        }
    }
}
