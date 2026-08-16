namespace IMDbApiLib.Models;

public abstract class ApiBaseModel
{
    public bool Success => string.IsNullOrEmpty(ErrorMessage);
    public string? ErrorMessage { get; set; }
}