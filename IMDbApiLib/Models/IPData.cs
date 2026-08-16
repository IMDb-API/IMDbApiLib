namespace IMDbApiLib.Models;

public class IPData : ApiBaseModel
{
    public IPData()
    {
    }

    public IPData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public IPData(string ip, string errorMessage)
    {
        Query = ip;
        ErrorMessage = errorMessage;
    }

    public string Query { get; set; } = string.Empty;
    public string Continent { get; set; } = string.Empty;
    public string ContinentCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;

    public string UrlPng
    {
        get
        {
            if (string.IsNullOrEmpty(CountryCode))
            {
                return string.Empty;
            }

            return $"https://tv-api.com/images/flags/{CountryCode.ToLower()}.png";
        }
    }

    public string UrlSvg
    {
        get
        {
            if (string.IsNullOrEmpty(CountryCode))
            {
                return string.Empty;
            }

            return $"https://tv-api.com/images/flags-svg/{CountryCode.ToLower()}.svg";
        }
    }

    public string Region { get; set; } = string.Empty;
    public string RegionName { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Zip { get; set; } = string.Empty;
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string Timezone { get; set; } = string.Empty;
    public int Offset { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string Isp { get; set; } = string.Empty;
    public string Org { get; set; } = string.Empty;
    public string As { get; set; } = string.Empty;
}