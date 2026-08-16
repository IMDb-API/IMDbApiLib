namespace IMDbApiLib.Models;

public class ReportData : ApiBaseModel
{
    public ReportData()
    {
    }

    public ReportData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public ReportData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Html { get; set; } = string.Empty;
}