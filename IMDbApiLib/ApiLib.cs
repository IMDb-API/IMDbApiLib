using System.Net;
using System.Text.Json;

namespace IMDbApiLib;

/// <summary>
/// Provides strongly typed access to movie, TV series, episode, cast, crew, person, chart, and related media endpoints exposed by TV-API.
/// </summary>
public partial class ApiLib : IDisposable
{
    /// <summary>
    /// Gets the base URL used for TV-API requests.
    /// </summary>
    public string BaseUrl => "https://tv-api.com";

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly string _apiKey;

    private readonly HttpClient _httpClient;

    private bool _disposed;

    private readonly WebProxy? _webProxy;

    /// <summary>
    /// Initializes a TV-API client using the specified API key.
    /// </summary>
    /// <param name="apiKey">Your API Key. This parameter is required for authentication and must be included in every request.</param>
    public ApiLib(string apiKey)
    {
        _apiKey = ValidateApiKey(apiKey);
        _httpClient = CreateHttpClient(null);
    }

    /// <summary>
    /// Initializes a TV-API client using the specified API key and web proxy.
    /// </summary>
    /// <param name="apiKey">Your API Key. This parameter is required for authentication and must be included in every request.</param>
    /// <param name="webProxy">The web proxy used for API requests.</param>
    public ApiLib(string apiKey, WebProxy webProxy)
    {
        _apiKey = ValidateApiKey(apiKey);
        _webProxy = webProxy ?? throw new ArgumentNullException(nameof(webProxy));
        _httpClient = CreateHttpClient(_webProxy);
    }

    /// <summary>
    /// Initializes a TV-API client using the specified API key and optional proxy settings.
    /// </summary>
    /// <param name="apiKey">Your API Key. This parameter is required for authentication and must be included in every request.</param>
    /// <param name="proxyAddress">The absolute proxy address, or <see langword="null"/> to connect directly.</param>
    /// <param name="proxyUsername">The optional proxy username.</param>
    /// <param name="proxyPassword">The optional proxy password.</param>
    public ApiLib(string apiKey, string? proxyAddress, string? proxyUsername = null, string? proxyPassword = null)
    {
        _apiKey = ValidateApiKey(apiKey);

        if (!string.IsNullOrWhiteSpace(proxyAddress))
        {
            var webProxy = new WebProxy
            {
                Address = new Uri(proxyAddress, UriKind.Absolute),
                BypassProxyOnLocal = false
            };

            if (!string.IsNullOrWhiteSpace(proxyUsername) && !string.IsNullOrWhiteSpace(proxyPassword))
            {
                webProxy.Credentials = new NetworkCredential(proxyUsername, proxyPassword);
                webProxy.UseDefaultCredentials = false;
            }

            _webProxy = webProxy;
        }

        _httpClient = CreateHttpClient(_webProxy);
    }

    private static string ValidateApiKey(string apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentException("API key cannot be null, empty, or whitespace.", nameof(apiKey));
        }

        return apiKey.Trim();
    }

    private static HttpClient CreateHttpClient(WebProxy? proxy)
    {
        var handler = new HttpClientHandler();
        if (proxy != null)
        {
            handler.Proxy = proxy;
            handler.UseProxy = true;
        }

        return new HttpClient(handler, disposeHandler: true);
    }

    private static string Encode(string? value) => Uri.EscapeDataString(value ?? string.Empty);

    private static string EnumValue(Enum value) => value.ToString().ToLowerInvariant();

    private static void EnsureNotNullOrWhiteSpace(string value, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value cannot be null, empty, or whitespace.", parameterName);
        }
    }

    /// <summary>
    /// Downloads a text response from the specified URL.
    /// </summary>
    /// <param name="url">The absolute URL to request.</param>
    /// <returns>The response content as text.</returns>
    public async Task<string?> GetStringAsync(string url)
    {
        ThrowIfDisposed();
        EnsureNotNullOrWhiteSpace(url, nameof(url));

        using var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Downloads and deserializes a JSON response from the specified URL.
    /// </summary>
    /// <typeparam name="T">The response type.</typeparam>
    /// <param name="url">The absolute URL to request.</param>
    /// <returns>The deserialized response object.</returns>
    public async Task<T?> GetObjectAsync<T>(string url)
    {
        string json = await GetStringAsync(url).ConfigureAwait(false)
            ?? throw new InvalidOperationException("The API returned an empty response.");

        return JsonSerializer.Deserialize<T>(json, _jsonOptions)
            ?? throw new JsonException($"The API response could not be deserialized as {typeof(T).Name}.");
    }

    /// <summary>
    /// Downloads binary content from the specified URL.
    /// </summary>
    /// <param name="url">The absolute URL to request.</param>
    /// <returns>The downloaded binary content.</returns>
    public async Task<byte[]?> GetBytesAsync(string url)
    {
        ThrowIfDisposed();
        EnsureNotNullOrWhiteSpace(url, nameof(url));

        using var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
    }

    /// <summary>
    /// Downloads content from the specified URL and saves it asynchronously to a file.
    /// </summary>
    /// <param name="url">The absolute URL to download.</param>
    /// <param name="filePath">The destination file path.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task SaveFileAsync(string url, string filePath)
    {
        EnsureNotNullOrWhiteSpace(filePath, nameof(filePath));
        byte[] bytes = await GetBytesAsync(url).ConfigureAwait(false)
            ?? throw new InvalidOperationException("The API returned an empty file.");
        using var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 81920, useAsync: true);
        await stream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(ApiLib));
        }
    }

    /// <summary>
    /// Releases the HTTP resources used by this client.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _httpClient.Dispose();
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}