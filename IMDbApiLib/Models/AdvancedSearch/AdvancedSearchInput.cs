using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace IMDbApiLib.Models
{
    public class AdvancedSearchInput
    {
        // title
        [Display(Name = "Title")]
        [StringLength(200, ErrorMessage = "ErrStringLength")]
        public string Title { get; set; }

        // title_type
        [Display(Name = "Title Type")]
        public AdvancedSearchTitleType? TitleType { get; set; }

        // release_date
        [Display(Name = "Release Date from")]
        public string ReleaseDateFrom { get; set; }
        [Display(Name = "Release Date to")]
        public string ReleaseDateTo { get; set; }

        // user_rating
        [Display(Name = "User Rating from")]
        public decimal? UserRatingFrom { get; set; }
        [Display(Name = "User Rating to")]
        public decimal? UserRatingTo { get; set; }

        // num_votes
        [Display(Name = "Number of Votes from")]
        public int? NumberOfVotesFrom { get; set; }
        [Display(Name = "Number of Votes to")]
        public int? NumberOfVotesTo { get; set; }

        // genres
        [Display(Name = "Genre")]
        public AdvancedSearchGenre? Genres { get; set; }

        // groups
        [Display(Name = "Title Groups")]
        public AdvancedSearchTitleGroup? TitleGroups { get; set; }

        // has
        [Display(Name = "Title Data")]
        public AdvancedSearchTitleData? TitleData { get; set; }

        // companies
        [Display(Name = "Companies")]
        public AdvancedSearchCompany? Companies { get; set; }

        // online_availability
        [Display(Name = "Instant Watch Options")]
        public AdvancedSearchInstantWatchOptions? InstantWatchOptions { get; set; }

        // certificates
        [Display(Name = "US Certificates")]
        public AdvancedSearchUSCertificate? USCertificates { get; set; }

        // colors
        [Display(Name = "Color Info")]
        public AdvancedSearchColorInfo? ColorInfo { get; set; }

        // countries
        [Display(Name = "Countries")]
        public AdvancedSearchCountry? Countries { get; set; }

        [Display(Name = "Countries")]
        public string CountriesStr { get; set; }

        // keywords
        [Display(Name = "Keyword")]
        [StringLength(200, ErrorMessage = "ErrStringLength")]
        public string Keyword { get; set; }

        // languages
        [Display(Name = "Languages")]
        public AdvancedSearchLanguage? Languages { get; set; }
        [Display(Name = "Languages")]
        public string LanguagesStr { get; set; }

        // locations
        [Display(Name = "Filming Locations")]
        [StringLength(200, ErrorMessage = "ErrStringLength")]
        public string FilmingLocations { get; set; }

        // moviemeter
        [Display(Name = "Popularity from")]
        public int? PopularityFrom { get; set; }
        [Display(Name = "Popularity to")]
        public int? PopularityTo { get; set; }

        // plot
        [Display(Name = "Plot")]
        [StringLength(200, ErrorMessage = "ErrStringLength")]
        public string Plot { get; set; }

        // runtime
        [Display(Name = "Runtime from")]
        public int? RuntimeFrom { get; set; }
        [Display(Name = "Runtime to")]
        public int? RuntimeTo { get; set; }

        // sound_mixes
        [Display(Name = "Sound Mix")]
        public AdvancedSearchSoundMix? SoundMix { get; set; }

        /* --------------------- SORT --------------------- */
        // count
        [Display(Name = "Count")]
        public AdvancedSearchCount? Count { get; set; }

        // sort
        [Display(Name = "Sort")]
        public AdvancedSearchSort? Sort { get; set; }


        public override string ToString()
        {
            var queries = new List<string>();
            SingleValueToQueryString(queries, "title", Title);
            EnumToQueryString(queries, "title_type", TitleType);
            EnumToQueryString(queries, "title_type", TitleType);
            ReleaseDateFrom = CheckDate(ReleaseDateFrom);
            ReleaseDateTo = CheckDate(ReleaseDateTo);
            TwoValuesToQueryString(queries, "release_date", ReleaseDateFrom, ReleaseDateTo);
            TwoValuesToQueryString(queries, "user_rating", UserRatingFrom, UserRatingTo);
            TwoValuesToQueryString(queries, "num_votes", NumberOfVotesFrom, NumberOfVotesTo);
            EnumToQueryString(queries, "genres", Genres);
            EnumToQueryString(queries, "groups", TitleGroups);
            EnumToQueryString(queries, "companies", Companies);
            EnumToQueryString(queries, "online_availability", InstantWatchOptions);
            EnumToQueryString(queries, "certificates", USCertificates);
            EnumToQueryString(queries, "colors", ColorInfo);
            if (!string.IsNullOrEmpty(CountriesStr))
                queries.Add($"countries={CountriesStr}");
            else
                EnumSingleValueToQueryString(queries, "countries", Countries);
            SingleValueToQueryString(queries, "keywords", Keyword);
            if (!string.IsNullOrEmpty(LanguagesStr))
                queries.Add($"languages={LanguagesStr}");
            else
                EnumSingleValueToQueryString(queries, "languages", Languages);
            SingleValueToQueryString(queries, "locations", FilmingLocations);
            TwoValuesToQueryString(queries, "moviemeter", PopularityFrom, PopularityTo);
            SingleValueToQueryString(queries, "plot", Plot);
            TwoValuesToQueryString(queries, "runtime", RuntimeFrom, RuntimeTo);
            EnumToQueryString(queries, "sound_mixes", SoundMix);
            EnumToQueryString(queries, "count", Count);
            EnumToQueryString(queries, "sort", Sort);

            if (queries.Count > 0)
                return $"?{string.Join("&", queries)}";

            return string.Empty;
        }

        #region Advanced Search Input Utils
        public static List<EnumDisplayNameDescription<T>> AllEnumValues<T>() where T : Enum
        {
            var result = new List<EnumDisplayNameDescription<T>>();
            foreach (T sx in Enum.GetValues(typeof(T)))
            {
                if (string.IsNullOrEmpty(sx.GetDescription()))
                    continue;
                result.Add(new EnumDisplayNameDescription<T>(sx, sx.GetDisplayName(), sx.GetDescription()));
            }

            return result;
        }

        private string CheckDate(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;

            if (DateTime.TryParse(date, out DateTime dt))
                return dt.ToString("yyyy-MM-dd");

            return string.Empty;
        }

        private void SingleValueToQueryString(List<string> queries, string fieldName, string fieldValue)
        {
            if (!string.IsNullOrEmpty(fieldValue))
                queries.Add($"{fieldName}={fieldValue}");
        }

        private static IEnumerable<string> GetFlags(Enum input)
        {
            foreach (Enum value in Enum.GetValues(input.GetType()))
                if (input.HasFlag(value))
                    yield return value.GetDescription();
        }

        public void EnumToQueryString(List<string> queries, string fieldName, Enum fieldValue)
        {
            if (fieldValue is null)
                return;

            var qs = GetFlags(fieldValue);

            if (qs.Count() > 0)
                queries.Add($"{fieldName}={string.Join(",", qs)}");
        }

        public void EnumSingleValueToQueryString(List<string> queries, string fieldName, Enum fieldValue)
        {
            if (fieldValue is null)
                return;

            queries.Add($"{fieldName}={fieldValue.GetDescription()}");
        }

        private void TwoValuesToQueryString(List<string> queries, string fieldName, string fieldValueFrom, string fieldValueTo)
        {
            if (!string.IsNullOrEmpty(fieldValueFrom) || !string.IsNullOrEmpty(fieldValueTo))
            {
                string v1 = "";
                string v2 = "";
                if (!string.IsNullOrEmpty(fieldValueFrom))
                    v1 = fieldValueFrom;
                if (!string.IsNullOrEmpty(fieldValueTo))
                    v2 = fieldValueTo;
                queries.Add($"{fieldName}={v1},{v2}");
            }
        }

        private void TwoValuesToQueryString(List<string> queries, string fieldName, decimal? fieldValueFrom, decimal? fieldValueTo)
        {
            if (fieldValueFrom.HasValue || fieldValueTo.HasValue)
            {
                string v1 = "";
                string v2 = "";
                if (fieldValueFrom.HasValue)
                    v1 = fieldValueFrom.Value.ToString("N2");
                if (fieldValueTo.HasValue)
                    v2 = fieldValueTo.Value.ToString("N2");
                queries.Add($"{fieldName}={v1},{v2}");
            }
        }

        private void TwoValuesToQueryString(List<string> queries, string fieldName, int? fieldValueFrom, int? fieldValueTo)
        {
            if (fieldValueFrom.HasValue || fieldValueTo.HasValue)
            {
                string v1 = "";
                string v2 = "";
                if (fieldValueFrom.HasValue)
                    v1 = fieldValueFrom.Value.ToString();
                if (fieldValueTo.HasValue)
                    v2 = fieldValueTo.Value.ToString();
                queries.Add($"{fieldName}={v1},{v2}");
            }
        }
        #endregion
    }
}