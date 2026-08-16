namespace IMDbApiLib.Models;

public class MetacriticReviewData : ApiBaseModel
{
    public MetacriticReviewData()
    {
    }

    public MetacriticReviewData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public MetacriticReviewData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<MetacriticReviewDataItem> Items { get; set; } = [];
}

public class MetacriticReviewDataItem
{
    public string Site { get; set; } = string.Empty;
    public string Reviewer { get; set; } = string.Empty;
    public int Score { get; set; }
    public string Content { get; set; } = string.Empty;
}