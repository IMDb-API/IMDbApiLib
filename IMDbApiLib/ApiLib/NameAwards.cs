using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<NameAwardData> NameAwardsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/NameAwards/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<NameAwardData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new NameAwardData() { ErrorMessage = ex.Message };
            }
        }
    }
}
