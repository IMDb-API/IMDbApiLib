using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves information about a country identified by its code.
    /// </summary>
    /// <param name="code">The country code (for example, "US" or "GB").</param>
    /// <returns>A <see cref="CountryData"/> object containing country details or an error message.</returns>
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