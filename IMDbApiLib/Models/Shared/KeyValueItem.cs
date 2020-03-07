namespace IMDbApiLib.Models
{
    public class KeyValueItem
    {
        public KeyValueItem() : this("", "")
        { }

        public KeyValueItem(string key) : this(key, key)
        { }

        public KeyValueItem(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}
