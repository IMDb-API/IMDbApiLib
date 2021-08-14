using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<NewMovieData> InTheatersAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/InTheaters/{_apiKey}";
                return await Utils.DownloadObjectAsync<NewMovieData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new NewMovieData() { ErrorMessage = ex.Message };
            }
        }
    }
}
