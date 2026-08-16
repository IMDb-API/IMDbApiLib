namespace IMDbApiLib;

public partial class ApiLib
{
    public async Task<byte[]?> ResizeImageAsync(string size, string url)
    {
        return await GetBytesAsync(ResizeImageUrl(size, url)).ConfigureAwait(false);
    }

    public async Task ResizeImageSaveFileAsync(string size, string url, string filePath)
    {
        await SaveFileAsync(ResizeImageUrl(size, url), filePath).ConfigureAwait(false);
    }

    public string ResizeImageUrl(string size, string url)
    {
        EnsureNotNullOrWhiteSpace(size, nameof(size));
        EnsureNotNullOrWhiteSpace(url, nameof(url));
        return $"{BaseUrl}/api/resize-image?apiKey={Encode(_apiKey)}&size={Encode(size)}&url={Encode(url)}";
    }
}
