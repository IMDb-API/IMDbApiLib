using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Structured country data covering demographics, capitals, currencies, languages, flags, calling codes, time zones, borders, economic details, memberships, and other essential information.
    /// </summary>
    /// <param name="code">ISO 3166-1 Alpha-2 code of the country or territory</param>
    /// <returns>The <see cref="CountryData"/> response containing the requested data or an error message.</returns>
    public async Task<CountryData?> CountriesAsync(string code)
    {
        try
        {
            string url = $"{BaseUrl}/api/countries?apiKey={Encode(_apiKey)}&code={Encode(code)}";
            return await GetObjectAsync<CountryData>(url);
        }
        catch (Exception ex)
        {
            return new CountryData() { ErrorMessage = ex.Message };
        }
    }
}