namespace IMDbApiLib.Models
{
    public class UsageData
    {
        public UsageData()
        {
            ErrorMessage = string.Empty;
        }

        public UsageData(string errorMessage)
        {
            Count = Maximum = 0;
            ErrorMessage = errorMessage;
        }

        public int Count { get; set; }
        public int Maximum { get; set; }
        public string Account { get; set; }
        public string ExpireDate { get; set; }
        public string ErrorMessage { get; set; }
    }
}