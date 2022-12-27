using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<ReviewData> ReviewsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Reviews/{_apiKey}/{id}";
                return await ApiUtils.GetObjectAsync<ReviewData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new ReviewData() { ErrorMessage = ex.Message };
            }
        }
    }
}
