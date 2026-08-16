namespace IMDbApiLib.Models;

public class NameAwardData : ApiBaseModel
{
    public NameAwardData()
    {
    }

    public NameAwardData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public NameAwardData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<NameAwardEvent> Items { get; set; } = [];
    public string NameAwardsHtml { get; set; } = string.Empty;
}

public class NameAwardEvent
{
    public string EventTitle { get; set; } = string.Empty;
    public List<NameAwardEventItem> Items { get; set; } = [];
}

public class NameAwardEventItem
{
    public string Image { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string For { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}