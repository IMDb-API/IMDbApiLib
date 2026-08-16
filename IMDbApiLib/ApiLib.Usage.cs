using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// View API usage statistics. This endpoint returns the number of daily requests made to the available services.
    /// </summary>
    /// <returns>The <see cref="UsageData"/> response containing the requested data or an error message.</returns>
    public async Task<UsageData?> UsageAsync()
    {
        try
        {
            string url = $"{BaseUrl}/api/usage?apiKey={Encode(_apiKey)}";
            return await GetObjectAsync<UsageData>(url);
        }
        catch (Exception ex)
        {
            return new UsageData() { ErrorMessage = ex.Message };
        }
    }
}