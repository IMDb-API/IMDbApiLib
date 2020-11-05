using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<ExternalSiteData> ExternalSitesAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/ExternalSites/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<ExternalSiteData>(url, _webProxy);
            }
            catch (Exception ex)
            {
                return new ExternalSiteData() { ErrorMessage = ex.Message };
            }
        }
    }
}
