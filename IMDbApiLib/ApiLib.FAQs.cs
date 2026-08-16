using IMDbApiLib.Models;

namespace IMDbApiLib;

public partial class ApiLib
{
    /// <summary>
    /// Get frequently asked questions and answers related to the API. This endpoint provides FAQ information and allows searching through available questions and answers.
    /// </summary>
    /// <param name="id">IMDb title ID. The ID must be a valid IMDb identifier starting with "tt". Example: "tt1375666"</param>
    /// <param name="lang">Language of the response. Default value is "en" (English). Some fields will be returned in the selected language.</param>
    /// <returns>The <see cref="FAQData"/> response containing the requested data or an error message.</returns>
    public async Task<FAQData?> FAQAsync(string id, Language lang = Language.EN)
    {
        try
        {
            string url = $"{BaseUrl}/api/faq?apiKey={Encode(_apiKey)}&id={Encode(id)}&lang={EnumValue(lang)}";
            return await GetObjectAsync<FAQData>(url);
        }
        catch (Exception ex)
        {
            return new FAQData() { ErrorMessage = ex.Message };
        }
    }
}