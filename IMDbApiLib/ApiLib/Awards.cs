using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<AwardData> AwardsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Awards/{_apiKey}/{id}";
                return await ApiUtils.GetObjectAsync<AwardData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new AwardData() { ErrorMessage = ex.Message };
            }
        }
    }
}
