namespace IMDbApiLib.Models;

public class GoofData : ApiBaseModel
{
    public GoofData()
    {
    }

    public GoofData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public GoofData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<GoofDataItem> Items { get; set; } = [];
}

public class GoofDataItem
{
    public string Category { get; set; } = string.Empty;
    public List<GoofDataItemDetail> Goofs { get; set; } = [];
    public List<GoofDataItemDetail> SpoilerGoofs { get; set; } = [];
}

public class GoofDataItemDetail
{
    public int HelpfulUp { get; set; }
    public int HelpfulDown { get; set; }
    public string PlainHtml { get; set; } = string.Empty;
    public string PlainText { get; set; } = string.Empty;
}