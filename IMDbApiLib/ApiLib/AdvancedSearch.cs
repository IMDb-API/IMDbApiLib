using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<AdvancedSearchData> AdvancedSearchAsync(AdvancedSearchInput advancedSearchInput)
        {
            try
            {
                string queryString = advancedSearchInput.ToString();
                if (string.IsNullOrEmpty(queryString))
                    throw new Exception("It is mandatory to enter at least one filter.");

                string url = $"{BaseUrl}/en/API/AdvancedSearch/{_apiKey}/{queryString}";
                return await ApiUtils.GetObjectAsync<AdvancedSearchData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new AdvancedSearchData() { ErrorMessage = ex.Message };
            }
        }
    }
}
