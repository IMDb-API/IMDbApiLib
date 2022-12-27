using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<MetacriticReviewData> MetacriticReviewsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/MetacriticReviews/{_apiKey}/{id}";
                return await ApiUtils.GetObjectAsync<MetacriticReviewData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new MetacriticReviewData() { ErrorMessage = ex.Message };
            }
        }
    }
}
