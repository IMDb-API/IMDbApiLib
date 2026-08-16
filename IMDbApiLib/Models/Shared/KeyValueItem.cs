namespace IMDbApiLib.Models;

public class KeyValueItem(string key, string value)
{
    public KeyValueItem() : this("", "")
    { }

    public KeyValueItem(string key) : this(key, key)
    { }

    public string Key { get; set; } = key;
    public string Value { get; set; } = value;
}