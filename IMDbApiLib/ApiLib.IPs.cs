using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get information about an IP address. This endpoint supports both IPv4 and IPv6 addresses and returns available details related to the provided IP.
    /// </summary>
    /// <param name="ip">The IPv4 or IPv6 address to retrieve information for.</param>
    /// <returns>The <see cref="IPData"/> response containing the requested data or an error message.</returns>
    public async Task<IPData?> IPsAsync(string ip)
    {
        try
        {
            string url = $"{BaseUrl}/api/ips?apiKey={Encode(_apiKey)}&ip={Encode(ip)}";
            return await GetObjectAsync<IPData>(url);
        }
        catch (Exception ex)
        {
            return new IPData() { ErrorMessage = ex.Message };
        }
    }
}