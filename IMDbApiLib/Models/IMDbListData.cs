namespace IMDbApiLib.Models;

public class IMDbListData : ApiBaseModel
{
    public IMDbListData()
    {
    }

    public IMDbListData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Title { get; set; } = string.Empty;
    public string By { get; set; } = string.Empty;
    public string Created { get; set; } = string.Empty;
    public string Updated { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<IMDbListDataItem> Items { get; set; } = [];
}

public class IMDbListDataItem
{
    public int Index { get; set; }
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Image { get; set; } = string.Empty;
    public decimal IMDbRating { get; set; }
    public int IMDbRatingVotes { get; set; }
}