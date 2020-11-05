using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<BoxOfficeAllTimeData> BoxOfficeAllTimeAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/BoxOfficeAllTime/{_apiKey}";
                return await Utils.DownloadObjectAsync<BoxOfficeAllTimeData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new BoxOfficeAllTimeData() { ErrorMessage = ex.Message };
            }
        }
    }
}
