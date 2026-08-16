namespace IMDbApiLib.Models;

public class CountryData : ApiBaseModel
{
    public CountryData()
    {
    }

    public CountryData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public string CommonName { get; set; } = string.Empty;
    public string OfficialName { get; set; } = string.Empty;
    public List<string> AlternateNames { get; set; } = [];
    public string NativeCommonName { get; set; } = string.Empty; // native.'fas'.common
    public string NativeOfficialName { get; set; } = string.Empty; // native.'fas'.official

    public string CodeAlpha2 { get; set; } = string.Empty;
    public string CodeAlpha3 { get; set; } = string.Empty;

    public CountryDataCoordinate Coordinate { get; set; } = new();

    public string Capital { get; set; } = string.Empty; // first of capitals
    public CountryDataCoordinate CapitalCoordinate { get; set; } = new();

    public string Emoji { get; set; } = string.Empty;
    public string HtmlEntity { get; set; } = string.Empty;
    public string Unicode { get; set; } = string.Empty;
    public string UrlPng { get; set; } = string.Empty; // my site
    public string UrlSvg { get; set; } = string.Empty; // my site, add svg

    public string Region { get; set; } = string.Empty;
    public string Subregion { get; set; } = string.Empty;
    public List<string> Continents { get; set; } = [];

    public decimal AreaKilometers { get; set; }
    public List<string> Borders { get; set; } = []; // alpha3 to alpha2
    public string CallingCodes { get; set; } = string.Empty;
    public string DrivingSide { get; set; } = string.Empty; // cars.driving_side
    public List<CountryDataCurrency> Currencies { get; set; } = [];
    public string DemonymFemale { get; set; } = string.Empty; // demonyms.eng.f
    public string DemonymMale { get; set; } = string.Empty; // demonyms.eng.m
    public List<CountryDataLanguage> Languages { get; set; } = [];
    public int Population { get; set; }
    public List<string> Timezones { get; set; } = [];
    public List<string> Tlds { get; set; } = [];
    public string UnitMeasurementSystem { get; set; } = string.Empty;
    public string UnitTemperatureScale { get; set; } = string.Empty;
}

public class CountryDataCoordinate
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}

public class CountryDataArea
{
    public decimal Kilometers { get; set; }
    public decimal Miles { get; set; }
}

public class CountryDataCurrency
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Symbol { get; set; } = string.Empty;
}

public class CountryDataLanguage
{
    public string Name { get; set; } = string.Empty;
    public string NativeName { get; set; } = string.Empty;
}