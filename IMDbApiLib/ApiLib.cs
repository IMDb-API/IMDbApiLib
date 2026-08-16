using System.Net;

namespace IMDbApiLib;

public partial class ApiLib
{
    #region Init

    public string BaseUrl => "https://tv-api.com";

    /// <summary>
    /// Gets the base URL used for API requests.
    /// </summary>

    private readonly string _apiKey;

    public readonly WebProxy? _webProxy = null;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiLib"/> class with the specified API key.
    /// </summary>
    /// <param name="apiKey">The API key to use for requests.</param>
    public ApiLib(string apiKey)
    {
        _apiKey = apiKey;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiLib"/> class with the specified API key and proxy.
    /// </summary>
    /// <param name="apiKey">The API key to use for requests.</param>
    /// <param name="webProxy">A <see cref="WebProxy"/> to use for HTTP requests.</param>
    public ApiLib(string apiKey, WebProxy webProxy)
    {
        _apiKey = apiKey;
        _webProxy = webProxy;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiLib"/> class with the specified API key and proxy settings.
    /// </summary>
    /// <param name="apiKey">The API key to use for requests.</param>
    /// <param name="proxyAddress">The proxy address (optional).</param>
    /// <param name="proxyUsername">The proxy username (optional).</param>
    /// <param name="proxyPassword">The proxy password (optional).</param>
    public ApiLib(string apiKey, string? proxyAddress, string? proxyUsername = null, string? proxyPassword = null)
    {
        _apiKey = apiKey;
        if (!string.IsNullOrEmpty(proxyAddress))
        {
            var webProxy = new WebProxy
            {
                Address = new Uri(proxyAddress),
            };

            if (!string.IsNullOrEmpty(proxyUsername) && !string.IsNullOrEmpty(proxyPassword))
            {
                webProxy.Credentials = new NetworkCredential(
                    proxyUsername,
                    proxyPassword);
                webProxy.UseDefaultCredentials = false;
            }

            webProxy.BypassProxyOnLocal = false;
            _webProxy = webProxy;
        }
    }

    #endregion Init

    #region Get Data

    /// <summary>
    /// Sends an HTTP GET request to the specified URL and returns the response content as a string.
    /// </summary>
    /// <param name="url">The request URL.</param>
    /// <returns>The response body as a string, or null if none.</returns>
    public async Task<string?> GetStringAsync(string url)
    {
        try
        {
            var handler = new HttpClientHandler();
            if (_webProxy != null)
            {
                handler.Proxy = _webProxy;
                handler.UseProxy = true;
            }

            using var client = new HttpClient(handler);
            return await client.GetStringAsync(url);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Sends an HTTP GET request to the specified URL and deserializes the JSON response to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type to deserialize the response into.</typeparam>
    /// <param name="url">The request URL.</param>
    /// <returns>An instance of <typeparamref name="T"/> or null if deserialization fails.</returns>
    public async Task<T?> GetObjectAsync<T>(string url)
    {
        try
        {
            string json = await GetStringAsync(url) ?? throw new NullReferenceException();
            return System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Downloads raw bytes from the specified URL.
    /// </summary>
    /// <param name="url">The resource URL.</param>
    /// <returns>The downloaded bytes, or null if the download fails.</returns>
    public async Task<byte[]?> GetBytesAsync(string url)
    {
        try
        {
            using var webClient = new WebClient();
            if (_webProxy != null)
            {
                webClient.Proxy = _webProxy;
            }

            return await webClient.DownloadDataTaskAsync(new Uri(url));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Downloads the content from the specified URL and saves it to the given file path.
    /// </summary>
    /// <param name="url">The URL to download.</param>
    /// <param name="filePath">The path where the file will be saved.</param>
    public async Task SaveFileAsync(string url, string filePath)
    {
        try
        {
            byte[]? bytes = await GetBytesAsync(url) ?? throw new NullReferenceException();
            File.WriteAllBytes(filePath, bytes);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion Get Data
}