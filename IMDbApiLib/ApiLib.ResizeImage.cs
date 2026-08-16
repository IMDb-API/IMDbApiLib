namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Downloads a resized version of an image from the given URL.
    /// </summary>
    /// <param name="size">The desired size identifier (e.g., "small", "medium", "large").</param>
    /// <param name="url">The original image URL to resize.</param>
    /// <returns>The resized image bytes, or null if the download fails.</returns>
    public async Task<byte[]?> ResizeImageAsync(string size, string url)
    {
        try
        {
            url = ResizeImageUrl(size, url);
            return await GetBytesAsync(url);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Downloads a resized image and saves it to the specified file path.
    /// </summary>
    /// <param name="size">The desired size identifier.</param>
    /// <param name="url">The original image URL to resize.</param>
    /// <param name="filePath">The file path where the image will be saved.</param>
    public async Task ResizeImageSaveFileAsync(string size, string url, string filePath)
    {
        try
        {
            url = ResizeImageUrl(size, url);
            await SaveFileAsync(url, filePath);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Builds the URL for requesting a resized image.
    /// </summary>
    /// <param name="size">The desired size identifier.</param>
    /// <param name="url">The original image URL.</param>
    /// <returns>The full API URL to request the resized image.</returns>
    public string ResizeImageUrl(string size, string url)
    {
        try
        {
            url = $"{BaseUrl}/api/resize-image?apiKey={_apiKey}&size={size}&url={url}".ToLower();
            return url;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}