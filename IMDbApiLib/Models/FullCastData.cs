namespace IMDbApiLib.Models;

public class FullCastData : ApiBaseModel
{
    public FullCastData()
    {
    }

    public FullCastData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public FullCastData(string id, string errorMessage)
    {
        IMDbId = id;
        ErrorMessage = errorMessage;
    }

    public string IMDbId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string FullTitle { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Year { get; set; }
    public CastShort Directors { get; set; } = new CastShort("Director");
    public CastShort Writers { get; set; } = new CastShort("Writer");
    public List<ActorShort> Actors { get; set; } = [];
    public List<CastShort> Others { get; set; } = [];
}

public class CastShort(string job)
{
    public string Job { get; set; } = job;
    public List<CastShortItem> Items { get; set; } = [];
}

public class CastShortItem
{
    public string IMDbId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class ActorShort
{
    public string IMDbId { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string AsCharacter { get; set; } = string.Empty;
}