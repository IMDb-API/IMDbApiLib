namespace IMDbApiLib.Models;

public class QuoteData : ApiBaseModel
{
    public QuoteData()
    {
    }

    public QuoteData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public QuoteData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<QuoteDataItem> Items { get; set; } = [];
}

public class QuoteDataItem
{
    public int HelpfulUp { get; set; }
    public int HelpfulDown { get; set; }
    public string PlainHtml { get; set; } = string.Empty;
    public string PlainText { get; set; } = string.Empty;
}