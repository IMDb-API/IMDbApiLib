namespace IMDbApiLib;

public partial class ApiLib
{
    public async Task<byte[]?> ResizePosterAsync(string size, string url)
    {
        return await GetBytesAsync(ResizePosterUrl(size, url)).ConfigureAwait(false);
    }

    public async Task ResizePosterSaveFileAsync(string size, string url, string filePath)
    {
        await SaveFileAsync(ResizePosterUrl(size, url), filePath).ConfigureAwait(false);
    }

    public string ResizePosterUrl(string size, string url)
    {
        EnsureNotNullOrWhiteSpace(size, nameof(size));
        EnsureNotNullOrWhiteSpace(url, nameof(url));
        return $"{BaseUrl}/api/resize-poster?apiKey={Encode(_apiKey)}&size={Encode(size)}&url={Encode(url)}";
    }
}
