namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Resize and optimize poster images using the provided poster URL. This endpoint allows changing poster dimensions based on supported sizes while maintaining image quality and returns the resized poster image URL.
    /// </summary>
    /// <param name="size">Size of the poster image. Supported sizes are available in two formats: Wide (6:9 or 9:6): "original", "w45", "w92", "w154", "w185", "w200", "w300", "w342", "w400", "w500", "w780", "w1280". Square (1:1): "s32", "s45", "s50", "s64", "s66", "s90", "s100", "s115", "s128", "s132", "s150", "s180", "s230", "s235", "s264", "s300", "s375", "s470".</param>
    /// <param name="url">URL of the poster image obtained from the "posters" service.</param>
    /// <returns>The resized binary poster data.</returns>
    public async Task<byte[]?> ResizePosterAsync(string size, string url)
    {
        return await GetBytesAsync(ResizePosterUrl(size, url)).ConfigureAwait(false);
    }

    /// <summary>
    /// Resizes the specified poster and saves the result asynchronously to a file.
    /// </summary>
    /// <param name="size">The requested poster size.</param>
    /// <param name="url">The source poster URL.</param>
    /// <param name="filePath">The destination file path.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task ResizePosterSaveFileAsync(string size, string url, string filePath)
    {
        await SaveFileAsync(ResizePosterUrl(size, url), filePath).ConfigureAwait(false);
    }

    /// <summary>
    /// Creates the TV-API URL used to resize the specified poster.
    /// </summary>
    /// <param name="size">The requested poster size.</param>
    /// <param name="url">The source poster URL.</param>
    /// <returns>The encoded resize endpoint URL.</returns>
    public string ResizePosterUrl(string size, string url)
    {
        EnsureNotNullOrWhiteSpace(size, nameof(size));
        EnsureNotNullOrWhiteSpace(url, nameof(url));
        return $"{BaseUrl}/api/resize-poster?apiKey={Encode(_apiKey)}&size={Encode(size)}&url={Encode(url)}";
    }
}
