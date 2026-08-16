namespace IMDbApiLib.Models;

public class SearchNameData : ApiBaseModel
{
    public SearchNameData()
    {
    }

    public SearchNameData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchNameDataItem> Items { get; set; } = [];
}

public class SearchNameDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Professions { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public SearchNameDataKnownFor KnownFor { get; set; } = new();
}

public class SearchNameDataKnownFor
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
}