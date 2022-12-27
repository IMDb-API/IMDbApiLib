using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<NewMovieData> ComingSoonAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/ComingSoon/{_apiKey}";
                return await ApiUtils.GetObjectAsync<NewMovieData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new NewMovieData() { ErrorMessage = ex.Message };
            }
        }
    }
}
