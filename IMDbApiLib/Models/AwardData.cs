namespace IMDbApiLib.Models;

public class AwardData : ApiBaseModel
{
    public AwardData()
    {
    }

    public AwardData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public AwardData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Description { get; set; } = string.Empty;
    public List<AwardDataEvent> Items { get; set; } = [];
    public string AwardsHtml { get; set; } = string.Empty;
}

public class AwardDataEvent
{
    public string EventTitle { get; set; } = string.Empty;
    public List<AwardDataEventItem> Items { get; set; } = [];
}

public class AwardDataEventItem
{
    public string Image { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string For { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}