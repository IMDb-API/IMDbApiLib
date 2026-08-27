using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace IMDbApiLib.Models;

public class AdvancedNameSearchInput
{
    [Display(Name = "Name", Description = "name")]
    public string? Name { get; set; }

    [Display(Name = "Birth date from", Description = "birth_date")]
    public string? BirthDateFrom { get; set; }

    [Display(Name = "Birth date to", Description = "birth_date")]
    public string? BirthDateTo { get; set; }

    [Display(Name = "Birthday", Description = "birth_monthday")]
    public string? Birthday { get; set; }

    [Display(Name = "Awards & recognition", Description = "groups")]
    public AdvancedNameSearchAward? Awards { get; set; }

    [Display(Name = "Page topics", Description = "has")]
    public AdvancedNameSearchPageTopic? PageTopics { get; set; }

    [Display(Name = "Award Nominations", Description = "award_nominations")]
    public string? AwardNominations { get; set; }

    [Display(Name = "Biography", Description = "bio")]
    public string? Biography { get; set; }

    [Display(Name = "Place of birth", Description = "birth_place")]
    public string? BirthPlace { get; set; }

    [Display(Name = "Place of death", Description = "death_place")]
    public string? DeathPlace { get; set; }

    [Display(Name = "Height info", Description = "height")]
    public string? Height { get; set; }

    [Display(Name = "Quotes", Description = "quotes")]
    public string? Quotes { get; set; }

    [Display(Name = "Trivia", Description = "trivia")]
    public string? Trivia { get; set; }

    [Display(Name = "Death date from", Description = "death_date")]
    public string? DeathDateFrom { get; set; }

    [Display(Name = "Death date to", Description = "death_date")]
    public string? DeathDateTo { get; set; }

    [Display(Name = "Gender identity", Description = "gender")]
    public AdvancedNameSearchGender? Gender { get; set; }

    [Display(Name = "Credits", Description = "roles")]
    public string? Credits { get; set; }

    public override string ToString()
    {
        var queries = new List<string>();
        SingleValueToQueryString(queries, "name", Name);
        TwoValuesToQueryString(queries, "birth_date", CheckDate(BirthDateFrom), CheckDate(BirthDateTo));
        SingleValueToQueryString(queries, "birth_monthday", CheckBirthday(Birthday));
        EnumToQueryString(queries, "groups", Awards);
        EnumToQueryString(queries, "has", PageTopics);
        SingleValueToQueryString(queries, "award_nominations", AwardNominations);
        SingleValueToQueryString(queries, "bio", Biography);
        SingleValueToQueryString(queries, "birth_place", BirthPlace);
        SingleValueToQueryString(queries, "death_place", DeathPlace);
        SingleValueToQueryString(queries, "height", Height);
        SingleValueToQueryString(queries, "quotes", Quotes);
        SingleValueToQueryString(queries, "trivia", Trivia);
        TwoValuesToQueryString(queries, "death_date", CheckDate(DeathDateFrom), CheckDate(DeathDateTo));
        EnumToQueryString(queries, "gender", Gender);
        SingleValueToQueryString(queries, "roles", Credits);

        return queries.Count > 0 ? $"?{string.Join("&", queries)}" : string.Empty;
    }

    #region Advanced Name Search Input Utils

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

    private static string CheckBirthday(string? birthday)
    {
        if (string.IsNullOrEmpty(birthday))
        {
            return string.Empty;
        }

        return DateTime.TryParseExact($"2000-{birthday}", "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _)
            ? birthday!
            : string.Empty;
    }

    private static void SingleValueToQueryString(List<string> queries, string fieldName, string? fieldValue)
    {
        if (!string.IsNullOrWhiteSpace(fieldValue))
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

    private static void EnumToQueryString(List<string> queries, string fieldName, Enum? fieldValue)
    {
        if (fieldValue is null)
        {
            return;
        }

        var values = GetFlags(fieldValue).Where(sx => !string.IsNullOrEmpty(sx));
        if (values.Any())
        {
            queries.Add($"{fieldName}={EncodeQueryValue(string.Join(",", values))}");
        }
    }

    private static void TwoValuesToQueryString(List<string> queries, string fieldName, string? fieldValueFrom, string? fieldValueTo)
    {
        if (!string.IsNullOrEmpty(fieldValueFrom) || !string.IsNullOrEmpty(fieldValueTo))
        {
            queries.Add($"{fieldName}={fieldValueFrom},{fieldValueTo}");
        }
    }

    private static string EncodeQueryValue(string? value) => Uri.EscapeDataString(value ?? string.Empty);

    #endregion Advanced Name Search Input Utils
}