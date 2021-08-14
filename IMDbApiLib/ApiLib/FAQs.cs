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
                string url = $"{BaseUrl}/en/API/FAQ/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<FAQData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new FAQData() { ErrorMessage = ex.Message };
            }
        }
    }
}
