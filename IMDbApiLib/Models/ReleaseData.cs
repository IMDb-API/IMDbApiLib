namespace IMDbApiLib.Models;

public class ReleaseData : ApiBaseModel
{
    public ReleaseData()
    {
    }

    public ReleaseData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public ReleaseData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Domestic { get; set; } = string.Empty;
    public long DomesticUsd { get; set; }
    public string DomesticPercent { get; set; } = string.Empty;
    public string International { get; set; } = string.Empty;
    public long InternationalUsd { get; set; }
    public string InternationalPercent { get; set; } = string.Empty;
    public string Worldwide { get; set; } = string.Empty;
    public long WorldwideUsd { get; set; }
    public List<ReleaseDataRelease> Releases { get; set; } = [];
    public List<ReleaseDataRegion> Regions { get; set; } = [];
}

public class ReleaseDataRelease
{
    public string ReleaseGroup { get; set; } = string.Empty;
    public string Rollout { get; set; } = string.Empty;
    public string Markets { get; set; } = string.Empty;
    public string Domestic { get; set; } = string.Empty;
    public long DomesticUsd { get; set; }
    public string International { get; set; } = string.Empty;
    public long InternationalUsd { get; set; }
    public string Worldwide { get; set; } = string.Empty;
    public long WorldwideUsd { get; set; }
}

public class ReleaseDataRegion
{
    public string Name { get; set; } = string.Empty;
    public int Releases { get; set; }
    public string LifetimeGross { get; set; } = string.Empty;
    public long LifetimeGrossUsd { get; set; }
    public int Rank { get; set; }
}