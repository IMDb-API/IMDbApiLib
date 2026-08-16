namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Downloads a resized poster image from the given URL.
    /// </summary>
    /// <param name="size">The desired poster size identifier.</param>
    /// <param name="url">The original poster URL to resize.</param>
    /// <returns>The resized poster bytes, or null if the download fails.</returns>
    public async Task<byte[]?> ResizePosterAsync(string size, string url)
    {
        try
        {
            url = ResizePosterUrl(size, url);
            return await GetBytesAsync(url);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Downloads a resized poster and saves it to the specified file path.
    /// </summary>
    /// <param name="size">The desired poster size identifier.</param>
    /// <param name="url">The original poster URL to resize.</param>
    /// <param name="filePath">The file path where the poster will be saved.</param>
    public async Task ResizePosterSaveFileAsync(string size, string url, string filePath)
    {
        try
        {
            url = ResizePosterUrl(size, url);
            await SaveFileAsync(url, filePath);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Builds the URL for requesting a resized poster.
    /// </summary>
    /// <param name="size">The desired poster size identifier.</param>
    /// <param name="url">The original poster URL.</param>
    /// <returns>The full API URL to request the resized poster.</returns>
    public string ResizePosterUrl(string size, string url)
    {
        try
        {
            url = $"{BaseUrl}/api/resize-poster?apiKey={_apiKey}&size={size}&url={url}".ToLower();
            return url;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}