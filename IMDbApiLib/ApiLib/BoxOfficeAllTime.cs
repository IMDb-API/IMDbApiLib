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
                return await ApiUtils.GetObjectAsync<BoxOfficeAllTimeData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new BoxOfficeAllTimeData() { ErrorMessage = ex.Message };
            }
        }
    }
}
