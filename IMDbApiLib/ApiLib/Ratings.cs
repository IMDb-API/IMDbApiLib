using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<RatingData> RatingsAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Ratings/{_apiKey}/{id}";
                return await ApiUtils.GetObjectAsync<RatingData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new RatingData() { ErrorMessage = ex.Message };
            }
        }
    }
}
