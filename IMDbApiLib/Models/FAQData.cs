namespace IMDbApiLib.Models;

public class FAQData : ApiBaseModel
{
    public FAQData()
    {
    }

    public FAQData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public FAQData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public List<FAQDataItem> Items { get; set; } = [];
    public List<FAQDataItem> SpoilerItems { get; set; } = [];
}

public class FAQDataItem
{
    public string Question { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
}