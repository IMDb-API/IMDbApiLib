using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<KeywordData> KeywordAsync(string kwId)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Keyword/{_apiKey}/{kwId}";
                return await Utils.DownloadObjectAsync<KeywordData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new KeywordData() { ErrorMessage = ex.Message };
            }
        }
    }
}
