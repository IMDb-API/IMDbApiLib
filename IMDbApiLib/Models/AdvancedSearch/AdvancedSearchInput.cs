using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace IMDbApiLib.Models;

public class AdvancedSearchInput
{
    [Display(Name = "Title name", Description = "title")]
    public string? Title { get; set; }

    [Display(Name = "Title type", Description = "title_type")]
    public AdvancedSearchTitleType? TitleType { get; set; }

    [Display(Name = "Release date from", Description = "release_date")]
    public string? ReleaseDateFrom { get; set; }

    [Display(Name = "Release date to", Description = "release_date")]
    public string? ReleaseDateTo { get; set; }

    [Display(Name = "IMDb ratings from", Description = "user_rating")]
    public decimal? UserRatingFrom { get; set; }

    [Display(Name = "IMDb ratings to", Description = "user_rating")]
    public decimal? UserRatingTo { get; set; }

    [Display(Name = "Number of votes from", Description = "num_votes")]
    public int? NumberOfVotesFrom { get; set; }

    [Display(Name = "Number of votes to", Description = "num_votes")]
    public int? NumberOfVotesTo { get; set; }

    [Display(Name = "Genre", Description = "genres")]
    public AdvancedSearchGenre? Genres { get; set; }

    [Display(Name = "Exclude", Description = "genres")]
    public AdvancedSearchExcludeGenre? ExcludedGenres { get; set; }

    [Display(Name = "Awards & recognition", Description = "groups")]
    public AdvancedSearchAward? Awards { get; set; }

    [Display(Name = "Page topics", Description = "has")]
    public AdvancedSearchPageTopic? PageTopics { get; set; }

    [Display(Name = "Alternate Versions", Description = "versions")]
    public string? AlternateVersions { get; set; }

    [Display(Name = "Awards", Description = "awards")]
    public string? AwardsTopic { get; set; }

    [Display(Name = "Business Info", Description = "business")]
    public string? BusinessInfo { get; set; }

    [Display(Name = "Crazy Credits", Description = "crazy_credits")]
    public string? CrazyCredits { get; set; }

    [Display(Name = "Goofs", Description = "goofs")]
    public string? Goofs { get; set; }

    [Display(Name = "Locations", Description = "locations")]
    public string? Locations { get; set; }

    [Display(Name = "Plot", Description = "plot")]
    public string? Plot { get; set; }

    [Display(Name = "Quotes", Description = "quotes")]
    public string? Quotes { get; set; }

    [Display(Name = "Soundtracks", Description = "soundtracks")]
    public string? Soundtracks { get; set; }

    [Display(Name = "Tech specs", Description = "technical")]
    public string? TechSpecs { get; set; }

    [Display(Name = "Trivia", Description = "trivia")]
    public string? Trivia { get; set; }

    [Display(Name = "Companies", Description = "companies")]
    public AdvancedSearchCompany? Companies { get; set; }

    [Display(Name = "Instant watch options", Description = "online_availability")]
    public AdvancedSearchInstantWatchOptions? InstantWatchOptions { get; set; }

    [Display(Name = "US certificates", Description = "certificates")]
    public AdvancedSearchUSCertificate? USCertificates { get; set; }

    [Display(Name = "Color info", Description = "colors")]
    public AdvancedSearchColorInfo? ColorInfo { get; set; }

    [Display(Name = "Country", Description = "countries")]
    public AdvancedSearchCountry? Countries { get; set; }

    [Display(Name = "Country", Description = "countries")]
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

    [Display(Name = "Sort by", Description = "sort")]
    public AdvancedSearchSort? Sort { get; set; }

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
        EnumWithExclusionsToQueryString(queries, "genres", Genres, ExcludedGenres);
        EnumToQueryString(queries, "groups", Awards);
        EnumToQueryString(queries, "has", PageTopics);
        SingleValueToQueryString(queries, "versions", AlternateVersions);
        SingleValueToQueryString(queries, "awards", AwardsTopic);
        SingleValueToQueryString(queries, "business", BusinessInfo);
        SingleValueToQueryString(queries, "crazy_credits", CrazyCredits);
        SingleValueToQueryString(queries, "goofs", Goofs);
        SingleValueToQueryString(queries, "locations", Locations);
        SingleValueToQueryString(queries, "plot", Plot);
        SingleValueToQueryString(queries, "quotes", Quotes);
        SingleValueToQueryString(queries, "soundtracks", Soundtracks);
        SingleValueToQueryString(queries, "technical", TechSpecs);
        SingleValueToQueryString(queries, "trivia", Trivia);
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
        TwoValuesToQueryString(queries, "runtime", RuntimeFrom, RuntimeTo);
        EnumToQueryString(queries, "sound_mixes", SoundMix);
        EnumSingleValueToQueryString(queries, "sort", Sort);

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

        string[] acceptedFormats = ["yyyy", "yyyy-MM", "yyyy-MM-dd"];
        return DateTime.TryParseExact(date, acceptedFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _)
            ? date!
            : string.Empty;
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

    private void EnumWithExclusionsToQueryString(List<string> queries, string fieldName, Enum? includedValues, Enum? excludedValues)
    {
        var values = new List<string>();
        if (includedValues is not null)
        {
            values.AddRange(GetFlags(includedValues));
        }

        if (excludedValues is not null)
        {
            values.AddRange(GetFlags(excludedValues).Select(ex => $"!{ex}"));
        }

        if (values.Count > 0)
        {
            queries.Add($"{fieldName}={EncodeQueryValue(string.Join(",", values))}");
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