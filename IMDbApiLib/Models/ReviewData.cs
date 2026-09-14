namespace IMDbApiLib.Models;

public class ReviewData : ApiBaseModel
{
    public ReviewData()
    {
    }

    public ReviewData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public ReviewData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<ReviewDataItem> Items { get; set; } = [];
}

public class ReviewDataItem
{
    public string Username { get; set; } = string.Empty;
    public string UserUrl { get; set; } = string.Empty;
    public string ReviewLink { get; set; } = string.Empty;
    public bool Spoiler { get; set; } = false;
    public string Date { get; set; } = string.Empty;
    public int Rate { get; set; }
    public int HelpfulUp { get; set; }
    public int HelpfulDown { get; set; }
    public string Title { get; set; } = string.Empty;
    public string PlainHtml { get; set; } = string.Empty;
    public string PlainText { get; set; } = string.Empty;
}