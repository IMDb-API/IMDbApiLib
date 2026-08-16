using System.Net;
using System.Text.Json;

namespace IMDbApiLib;

public partial class ApiLib : IDisposable
{
    public string BaseUrl => "https://tv-api.com";

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly string _apiKey;

    private readonly HttpClient _httpClient;

    private bool _disposed;

    private readonly WebProxy? _webProxy;

    public ApiLib(string apiKey)
    {
        _apiKey = ValidateApiKey(apiKey);
        _httpClient = CreateHttpClient(null);
    }

    public ApiLib(string apiKey, WebProxy webProxy)
    {
        _apiKey = ValidateApiKey(apiKey);
        _webProxy = webProxy ?? throw new ArgumentNullException(nameof(webProxy));
        _httpClient = CreateHttpClient(_webProxy);
    }

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

    public async Task<string?> GetStringAsync(string url)
    {
        ThrowIfDisposed();
        EnsureNotNullOrWhiteSpace(url, nameof(url));

        using var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    }

    public async Task<T?> GetObjectAsync<T>(string url)
    {
        string json = await GetStringAsync(url).ConfigureAwait(false)
            ?? throw new InvalidOperationException("The API returned an empty response.");

        return JsonSerializer.Deserialize<T>(json, _jsonOptions)
            ?? throw new JsonException($"The API response could not be deserialized as {typeof(T).Name}.");
    }

    public async Task<byte[]?> GetBytesAsync(string url)
    {
        ThrowIfDisposed();
        EnsureNotNullOrWhiteSpace(url, nameof(url));

        using var response = await _httpClient.GetAsync(url).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
    }

    public async Task SaveFileAsync(string url, string filePath)
    {
        EnsureNotNullOrWhiteSpace(filePath, nameof(filePath));
        byte[] bytes = await GetBytesAsync(url).ConfigureAwait(false)
            ?? throw new InvalidOperationException("The API returned an empty file.");
        File.WriteAllBytes(filePath, bytes);
    }

    private void ThrowIfDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(ApiLib));
        }
    }

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