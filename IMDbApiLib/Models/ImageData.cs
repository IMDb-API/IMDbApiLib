namespace IMDbApiLib.Models;

public class ImageData : ApiBaseModel
{
    public ImageData()
    {
    }

    public ImageData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public ImageData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<ImageDataItem> Items { get; set; } = [];
}

public class ImageDataItem
{
    public string Title { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}