namespace IMDbApiLib.Models;

public class AdvancedNameSearchData : ApiBaseModel
{
    public AdvancedNameSearchData()
    {
    }

    public AdvancedNameSearchData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string QueryString { get; set; } = string.Empty;
    public List<AdvancedNameSearchDataItem> Items { get; set; } = [];
}

public class AdvancedNameSearchDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Professions { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public AdvancedNameSearchDataKnownFor KnownFor { get; set; } = new();
}

public class AdvancedNameSearchDataKnownFor
{
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
}