namespace IMDbApiLib.Models;

public class SearchCompanyData : ApiBaseModel
{
    public SearchCompanyData()
    {
    }

    public SearchCompanyData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string Expression { get; set; } = string.Empty;
    public List<SearchCompanyDataItem> Items { get; set; } = [];
}

public class SearchCompanyDataItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}