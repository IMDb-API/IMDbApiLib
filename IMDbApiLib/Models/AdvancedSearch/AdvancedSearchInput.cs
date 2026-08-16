using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace IMDbApiLib.Models;

public class AdvancedSearchInput
{
    [Display(Name = "Title", Description = "title")]
    public string? Title { get; set; }

    [Display(Name = "Title type", Description = "title_type")]
    public AdvancedSearchTitleType? TitleType { get; set; }

    [Display(Name = "Release date from", Description = "release_date")]
    public string? ReleaseDateFrom { get; set; }

    [Display(Name = "Release date to", Description = "release_date")]
    public string? ReleaseDateTo { get; set; }

    [Display(Name = "IMDb ratings from", Description = "user_rating")]
    public decimal? UserRatingFrom { get; set; }

    [Display(Name = "IMDb rating to", Description = "user_rating")]
    public decimal? UserRatingTo { get; set; }

    [Display(Name = "Number of votes from", Description = "num_votes")]
    public int? NumberOfVotesFrom { get; set; }

    [Display(Name = "Number of votes to", Description = "num_votes")]
    public int? NumberOfVotesTo { get; set; }

    [Display(Name = "Genre", Description = "genres")]
    public AdvancedSearchGenre? Genres { get; set; }

    [Display(Name = "Awards & recognition", Description = "groups")]
    public AdvancedSearchAward? Awards { get; set; }

    [Display(Name = "Page topic", Description = "has")]
    public AdvancedSearchPageTopic? PageTopics { get; set; }

    [Display(Name = "Plot", Description = "plot")]
    public string? Plot { get; set; }

    [Display(Name = "Companies", Description = "companies")]
    public AdvancedSearchCompany? Companies { get; set; }

    [Display(Name = "Instant watch options", Description = "online_availability")]
    public AdvancedSearchInstantWatchOptions? InstantWatchOptions { get; set; }

    [Display(Name = "US certificates", Description = "certificates")]
    public AdvancedSearchUSCertificate? USCertificates { get; set; }

    [Display(Name = "Color info", Description = "colors")]
    public AdvancedSearchColorInfo? ColorInfo { get; set; }

    [Display(Name = "Countries", Description = "countries")]
    public AdvancedSearchCountry? Countries { get; set; }

    [Display(Name = "Countries", Description = "countries")]
    public string? CountriesStr { get; set; }

    [Display(Name = "Keywords", Description = "keywords")]
    public string? Keywords { get; set; }

    [Display(Name = "Languages", Description = "languages")]
    public AdvancedSearchLanguage? Languages { get; set; }

    [Display(Name = "Languages", Description = "languages")]
    public string? LanguagesStr { get; set; }

    [Display(Name = "IMDb popularity rank from", Description = "moviemeter")]
    public int? IMDbPopularityRankFrom { get; set; }

    [Display(Name = "IMDb popularity rank to", Description = "moviemeter")]
    public int? IMDbPopularityRankTo { get; set; }

    [Display(Name = "Cast or crew", Description = "role")]
    public string? CastOrCrew { get; set; }

    [Display(Name = "Characters", Description = "characters")]
    public string? Characters { get; set; }

    [Display(Name = "Runtime from", Description = "runtime")]
    public int? RuntimeFrom { get; set; }

    [Display(Name = "Runtime to", Description = "runtime")]
    public int? RuntimeTo { get; set; }

    [Display(Name = "Sound mix", Description = "sound_mixes")]
    public AdvancedSearchSoundMix? SoundMix { get; set; }

    public override string ToString()
    {
        var queries = new List<string>();
        SingleValueToQueryString(queries, "title", Title);
        EnumToQueryString(queries, "title_type", TitleType);
        string releaseDateFrom = CheckDate(ReleaseDateFrom);
        string releaseDateTo = CheckDate(ReleaseDateTo);
        TwoValuesToQueryString(queries, "release_date", releaseDateFrom, releaseDateTo);
        TwoValuesToQueryString(queries, "user_rating", UserRatingFrom, UserRatingTo);
        TwoValuesToQueryString(queries, "num_votes", NumberOfVotesFrom, NumberOfVotesTo);
        EnumToQueryString(queries, "genres", Genres);
        EnumToQueryString(queries, "groups", Awards);
        EnumToQueryString(queries, "has", PageTopics);
        EnumToQueryString(queries, "companies", Companies);
        EnumToQueryString(queries, "online_availability", InstantWatchOptions);
        EnumToQueryString(queries, "certificates", USCertificates);
        EnumToQueryString(queries, "colors", ColorInfo);
        if (!string.IsNullOrEmpty(CountriesStr))
        {
            queries.Add($"countries={EncodeQueryValue(CountriesStr)}");
        }
        else
        {
            EnumSingleValueToQueryString(queries, "countries", Countries);
        }
        SingleValueToQueryString(queries, "keywords", Keywords);
        if (!string.IsNullOrEmpty(LanguagesStr))
        {
            queries.Add($"languages={EncodeQueryValue(LanguagesStr)}");
        }
        else
        {
            EnumSingleValueToQueryString(queries, "languages", Languages);
        }
        TwoValuesToQueryString(queries, "moviemeter", IMDbPopularityRankFrom, IMDbPopularityRankTo);
        SingleValueToQueryString(queries, "role", CastOrCrew);
        SingleValueToQueryString(queries, "characters", Characters);
        SingleValueToQueryString(queries, "plot", Plot);
        TwoValuesToQueryString(queries, "runtime", RuntimeFrom, RuntimeTo);
        EnumToQueryString(queries, "sound_mixes", SoundMix);

        if (queries.Count > 0)
        {
            return $"?{string.Join("&", queries)}";
        }

        return string.Empty;
    }

    #region Advanced Search Input Utils

    public static List<EnumDisplayNameDescription<T>> AllEnumValues<T>() where T : Enum
    {
        var result = new List<EnumDisplayNameDescription<T>>();
        foreach (T sx in Enum.GetValues(typeof(T)))
        {
            if (string.IsNullOrEmpty(sx.GetDescription()))
            {
                continue;
            }

            result.Add(new EnumDisplayNameDescription<T>(sx, sx.GetDisplayName(), sx.GetDescription()));
        }

        return result;
    }

    private static string CheckDate(string? date)
    {
        if (string.IsNullOrEmpty(date))
        {
            return string.Empty;
        }

        if (DateTime.TryParse(date, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
        {
            return dt.ToString("yyyy-MM-dd");
        }

        return string.Empty;
    }

    private void SingleValueToQueryString(List<string> queries, string fieldName, string? fieldValue)
    {
        if (!string.IsNullOrEmpty(fieldValue))
        {
            queries.Add($"{fieldName}={EncodeQueryValue(fieldValue)}");
        }
    }

    private static IEnumerable<string> GetFlags(Enum input)
    {
        foreach (Enum value in Enum.GetValues(input.GetType()))
        {
            if (input.HasFlag(value))
            {
                yield return value.GetDescription();
            }
        }
    }

    public void EnumToQueryString(List<string> queries, string fieldName, Enum? fieldValue)
    {
        if (fieldValue is null)
        {
            return;
        }

        var qs = GetFlags(fieldValue);
        if (qs.Any())
        {
            queries.Add($"{fieldName}={EncodeQueryValue(string.Join(",", qs))}");
        }
    }

    public void EnumSingleValueToQueryString(List<string> queries, string fieldName, Enum? fieldValue)
    {
        if (fieldValue is null)
        {
            return;
        }

        queries.Add($"{fieldName}={EncodeQueryValue(fieldValue.GetDescription())}");
    }

    private void TwoValuesToQueryString(List<string> queries, string fieldName, string? fieldValueFrom, string? fieldValueTo)
    {
        if (!string.IsNullOrEmpty(fieldValueFrom) || !string.IsNullOrEmpty(fieldValueTo))
        {
            string? v1 = string.Empty;
            string? v2 = string.Empty;
            if (!string.IsNullOrEmpty(fieldValueFrom))
            {
                v1 = fieldValueFrom;
            }
            if (!string.IsNullOrEmpty(fieldValueTo))
            {
                v2 = fieldValueTo;
            }

            queries.Add($"{fieldName}={v1},{v2}");
        }
    }

    private void TwoValuesToQueryString(List<string> queries, string fieldName, decimal? fieldValueFrom, decimal? fieldValueTo)
    {
        if (fieldValueFrom.HasValue || fieldValueTo.HasValue)
        {
            string v1 = string.Empty;
            string v2 = string.Empty;
            if (fieldValueFrom.HasValue)
            {
                v1 = fieldValueFrom.Value.ToString("0.##", CultureInfo.InvariantCulture);
            }
            if (fieldValueTo.HasValue)
            {
                v2 = fieldValueTo.Value.ToString("0.##", CultureInfo.InvariantCulture);
            }

            queries.Add($"{fieldName}={v1},{v2}");
        }
    }

    private void TwoValuesToQueryString(List<string> queries, string fieldName, int? fieldValueFrom, int? fieldValueTo)
    {
        if (fieldValueFrom.HasValue || fieldValueTo.HasValue)
        {
            string v1 = string.Empty;
            string v2 = string.Empty;
            if (fieldValueFrom.HasValue)
            {
                v1 = fieldValueFrom.Value.ToString(CultureInfo.InvariantCulture);
            }
            if (fieldValueTo.HasValue)
            {
                v2 = fieldValueTo.Value.ToString(CultureInfo.InvariantCulture);
            }

            queries.Add($"{fieldName}={v1},{v2}");
        }
    }

    private static string EncodeQueryValue(string? value) => Uri.EscapeDataString(value ?? string.Empty);

    #endregion
}