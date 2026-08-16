using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves API usage information and limits for the current API key.
    /// </summary>
    /// <returns>A <see cref="UsageData"/> object containing usage statistics or an error message.</returns>
    public async Task<UsageData?> UsageAsync()
    {
        try
        {
            string url = $"{BaseUrl}/api/usage?apiKey={_apiKey}".ToLower();
            return await GetObjectAsync<UsageData>(url);
        }
        catch (Exception ex)
        {
            return new UsageData() { ErrorMessage = ex.Message };
        }
    }
}