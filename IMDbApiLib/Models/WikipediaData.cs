namespace IMDbApiLib.Models;

public class WikipediaData : ApiBaseModel
{
    public WikipediaData()
    {
    }

    public WikipediaData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public WikipediaData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Language { get; set; } = string.Empty;
    public string TitleInLanguage { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string HtmlBody { get; set; } = string.Empty;
}