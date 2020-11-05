using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<BoxOfficeWeekendData> BoxOfficeAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/BoxOffice/{_apiKey}";
                return await Utils.DownloadObjectAsync<BoxOfficeWeekendData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new BoxOfficeWeekendData() { ErrorMessage = ex.Message };
            }
        }
    }
}
