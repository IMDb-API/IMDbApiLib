using System.Text;

namespace IMDbApiLib.Models;

public class Options
{
    public Options(ref string? options)
    {
        string originalOptions = options ?? string.Empty;
        options ??= string.Empty;
        if (!options.StartsWith(""))
        {
            options = $"/{options}";
        }
        options = options.ToLower();

        FullCast = options.Contains("fullcast");
        FullActor = options.Contains("fullactor") || options.Contains("fullcast");
        Wikipedia = options.Contains("wikipedia");
        Posters = options.Contains("posters") || options.Contains("poster");
        Images = options.Contains("images") || options.Contains("image");
        Trailer = options.Contains("trailers") || options.Contains("trailer");
        Ratings = options.Contains("ratings") || options.Contains("rating");

        string[] optionItems = originalOptions.Split(new[] { '/', ',', '{', '}', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string item in optionItems)
        {
            bool isRegularKey = item.Length == 20;
            bool isPublicKey = item.Length == 30 && item.StartsWith("pk_", StringComparison.Ordinal);
            if (isRegularKey || isPublicKey)
            {
                ApiKey = item;
                break;
            }
        }
    }

    public string ApiKey { get; set; } = string.Empty;

    public bool FullActor { get; set; }
    public bool FullCast { get; set; }
    public bool Wikipedia { get; set; }
    public bool Posters { get; set; }
    public bool Images { get; set; }
    public bool Trailer { get; set; }
    public bool Ratings { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var lst = new List<string>();

        if (FullActor)
        {
            lst.Add($"{nameof(FullActor)}");
        }

        if (FullCast)
        {
            lst.Add($"{nameof(FullCast)}");
        }

        if (Wikipedia)
        {
            lst.Add($"{nameof(Wikipedia)}");
        }

        if (Posters)
        {
            lst.Add($"{nameof(Posters)}");
        }

        if (Images)
        {
            lst.Add($"{nameof(Images)}");
        }

        if (Trailer)
        {
            lst.Add($"{nameof(Trailer)}");
        }

        if (Ratings)
        {
            lst.Add($"{nameof(Ratings)}");
        }

        sb.Append('{');
        sb.Append(string.Join(",", lst));
        sb.Append('}');

        return sb.ToString();
    }

    public static string OptionsToString(bool fullActor, bool fullCast, bool wikipedia, bool posters, bool images, bool trailer, bool ratings)
    {
        var lst = new List<string>();
        if (fullActor)
        {
            lst.Add($"{nameof(fullActor)}".ToLower());
        }

        if (fullCast)
        {
            lst.Add($"{nameof(fullCast)}".ToLower());
        }

        if (wikipedia)
        {
            lst.Add($"{nameof(wikipedia)}".ToLower());
        }

        if (posters)
        {
            lst.Add($"{nameof(posters)}".ToLower());
        }

        if (images)
        {
            lst.Add($"{nameof(images)}".ToLower());
        }

        if (trailer)
        {
            lst.Add($"{nameof(trailer)}".ToLower());
        }

        if (ratings)
        {
            lst.Add($"{nameof(ratings)}".ToLower());
        }

        string options = string.Join(",", lst);
        return options;
    }
}