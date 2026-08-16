using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves information for a given IP address.
    /// </summary>
    /// <param name="ip">The IPv4 or IPv6 address to lookup.</param>
    /// <returns>An <see cref="IPData"/> object containing IP information or an error message.</returns>
    public async Task<IPData?> IPsAsync(string ip)
    {
        try
        {
            string url = $"{BaseUrl}/api/ips?apiKey={_apiKey}&ip={ip}".ToLower();
            return await GetObjectAsync<IPData>(url);
        }
        catch (Exception ex)
        {
            return new IPData() { ErrorMessage = ex.Message };
        }
    }
}