namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Resize and optimize images using the provided image URL. This endpoint allows changing image dimensions while maintaining the original image quality and returns the resized image URL.
    /// </summary>
    /// <param name="size">Size of the image in "Width x Height" format. Examples: "8x11", "16x22", "32x44", "64x88"</param>
    /// <param name="url">The image URL that you want to resize. The URL must point to a valid image file.</param>
    /// <returns>The resized binary image data.</returns>
    public async Task<byte[]?> ResizeImageAsync(string size, string url)
    {
        return await GetBytesAsync(ResizeImageUrl(size, url)).ConfigureAwait(false);
    }

    /// <summary>
    /// Resizes the specified image and saves the result asynchronously to a file.
    /// </summary>
    /// <param name="size">The requested image size.</param>
    /// <param name="url">The source image URL.</param>
    /// <param name="filePath">The destination file path.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task ResizeImageSaveFileAsync(string size, string url, string filePath)
    {
        await SaveFileAsync(ResizeImageUrl(size, url), filePath).ConfigureAwait(false);
    }

    /// <summary>
    /// Creates the TV-API URL used to resize the specified image.
    /// </summary>
    /// <param name="size">The requested image size.</param>
    /// <param name="url">The source image URL.</param>
    /// <returns>The encoded resize endpoint URL.</returns>
    public string ResizeImageUrl(string size, string url)
    {
        EnsureNotNullOrWhiteSpace(size, nameof(size));
        EnsureNotNullOrWhiteSpace(url, nameof(url));
        return $"{BaseUrl}/api/resize-image?apiKey={Encode(_apiKey)}&size={Encode(size)}&url={Encode(url)}";
    }
}
