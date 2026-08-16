namespace IMDbApiLib.Models;

public class UsageData : ApiBaseModel
{
    public UsageData()
    {
    }

    public UsageData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public int Count { get; set; }
    public int Maximum { get; set; }
    public string Account { get; set; } = string.Empty;
    public string ExpireDate { get; set; } = string.Empty;
}