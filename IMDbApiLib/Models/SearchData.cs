namespace IMDbApiLib.Models;

public class SearchData : ApiBaseModel
{
    public SearchData()
    {
    }

    public SearchData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchTitleDataItem> Movies { get; set; } = [];
    public List<SearchTitleDataItem> Series { get; set; } = [];
    public List<SearchNameDataItem> Names { get; set; } = [];
}

public enum SearchType
{
    Title = 1,
    Movie = 2,
    Series = 4,
    Name = 8,
    Episode = 16,
    Company = 32,
    Keyword = 64,
    All = 128
}