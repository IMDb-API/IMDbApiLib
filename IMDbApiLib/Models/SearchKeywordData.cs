namespace IMDbApiLib.Models;

public class SearchKeywordData : ApiBaseModel
{
    public SearchKeywordData()
    {
    }

    public SearchKeywordData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchKeywordDataItem> Items { get; set; } = [];
}

public class SearchKeywordDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public int NumberOfTitles { get; set; }
}