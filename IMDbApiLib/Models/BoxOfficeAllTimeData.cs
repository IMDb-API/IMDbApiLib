namespace IMDbApiLib.Models;

public class BoxOfficeAllTimeData : ApiBaseModel
{
    public BoxOfficeAllTimeData()
    {
    }

    public BoxOfficeAllTimeData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public List<BoxOfficeAllTimeDataItem> Items { get; set; } = [];
}

public class BoxOfficeAllTimeDataItem
{
    public int Rank { get; set; }
    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Type { get; set; } = string.Empty;
    public string WorldwideLifetimeGross { get; set; } = string.Empty;
    public long WorldwideLifetimeGrossUsd { get; set; }
    public string DomesticLifetimeGross { get; set; } = string.Empty;
    public long DomesticLifetimeGrossUsd { get; set; }
    public string Domestic { get; set; } = string.Empty;
    public string ForeignLifetimeGross { get; set; } = string.Empty;
    public long ForeignLifetimeGrossUsd { get; set; }
    public string Foreign { get; set; } = string.Empty;
}