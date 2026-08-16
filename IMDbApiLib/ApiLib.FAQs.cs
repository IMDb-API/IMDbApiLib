using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Retrieves frequently asked questions for the specified title or person identifier.
    /// </summary>
    /// <param name="id">The IMDb identifier for the title or person.</param>
    /// <param name="lang">The language for returned data (default is English).</param>
    /// <returns>An <see cref="FAQData"/> object containing FAQ items or an error message.</returns>
    public async Task<FAQData?> FAQsAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/faq?apiKey={_apiKey}&id={id}&lang={lang}".ToLower();
            return await GetObjectAsync<FAQData>(url);
        }
        catch (Exception ex)
        {
            return new FAQData() { ErrorMessage = ex.Message };
        }
    }
}