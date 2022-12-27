using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<UsageData> UsageAsync()
        {
            try
            {
                string url = $"{BaseUrl}/API/Usage/{_apiKey}";
                return await ApiUtils.GetObjectAsync<UsageData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new UsageData() { ErrorMessage = ex.Message };
            }
        }
    }
}
