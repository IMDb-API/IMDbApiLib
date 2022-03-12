namespace IMDbApiLib.Models
{
    public class UsageData
    {
        public int Count { get; set; }
        public int Maximum { get; set; }

        public string Account { get; set; }
        public string ExpireDate { get; set; }

        public string ErrorMessage { get; set; }
    }
}