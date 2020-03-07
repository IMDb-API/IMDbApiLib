using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class zFlags
    {
        public zFlags(string baseUrl, List<KeyValueItem> countryList)
        {
            Flag1 = null;
            Flag2 = null;
            Flag3 = null;

            if (countryList is null)
                return;

            if (countryList.Count > 0)
                Flag1 = $"{baseUrl}/images/flags/{countryList[0].Key.Replace(" ", "_")}.png";

            if (countryList.Count > 1)
                Flag2 = $"{baseUrl}/images/flags/{countryList[1].Key.Replace(" ", "_")}.png";

            if (countryList.Count > 2)
                Flag3 = $"{baseUrl}/images/flags/{countryList[2].Key.Replace(" ", "_")}.png";
        }

        public string Flag1 { get; set; }
        public string Flag2 { get; set; }
        public string Flag3 { get; set; }
    }
}
