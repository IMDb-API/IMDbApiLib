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
                return await Utils.DownloadObjectAsync<NewMovieData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new NewMovieData() { ErrorMessage = ex.Message };
            }
        }
    }
}
