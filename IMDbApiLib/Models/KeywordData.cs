namespace IMDbApiLib.Models;

public class KeywordData : ApiBaseModel
{
    public KeywordData()
    {
    }

    public KeywordData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public KeywordData(string keyword, string errorMessage)
    {
        Keyword = keyword;
        ErrorMessage = errorMessage;
    }

    public string Keyword { get; set; } = string.Empty;
    public List<MovieShort> Items { get; set; } = [];
}