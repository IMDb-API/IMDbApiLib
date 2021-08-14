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
                return await Utils.DownloadObjectAsync<KeywordData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new KeywordData() { ErrorMessage = ex.Message };
            }
        }
    }
}
