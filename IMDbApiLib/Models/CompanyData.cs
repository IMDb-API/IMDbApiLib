namespace IMDbApiLib.Models;

public class CompanyData : ApiBaseModel
{
    public CompanyData()
    {
    }

    public CompanyData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public CompanyData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<MovieShort> Items { get; set; } = [];
}