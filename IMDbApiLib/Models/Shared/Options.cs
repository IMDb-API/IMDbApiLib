using System.Collections.Generic;
using System.Text;

namespace IMDbApiLib.Models
{
    public class Options
    {
        public Options(ref string options)
        {
            string originalOptions = new string(options.ToCharArray());
            if (string.IsNullOrEmpty(options))
                options = string.Empty;
            else
            {
                if (!options.StartsWith("/"))
                    options = $"/{options}";
                options = options.ToLower();
            }


            FullCast = options.Contains("fullcast");
            FullActor = options.Contains("fullactor") || options.Contains("fullcast");
            Wikipedia = options.Contains("wikipedia");
            Posters = options.Contains("posters") || options.Contains("poster");
            Images = options.Contains("images") || options.Contains("image");
            Trailer = options.Contains("trailers") || options.Contains("trailer");
            Ratings = options.Contains("ratings") || options.Contains("rating");

            int indexOf = originalOptions.IndexOf("k_");
            if (indexOf != -1)
            {
                string key = originalOptions.Substring(indexOf, 10); // 10 chars
                if (!string.IsNullOrEmpty(key) && key.Length == 10)
                    ApiKey = key;
            }
        }

        public bool FullActor { get; set; }
        public bool FullCast { get; set; }
        public bool Wikipedia { get; set; }
        public bool Posters { get; set; }
        public bool Images { get; set; }
        public bool Trailer { get; set; }
        public bool Ratings { get; set; }

        public string ApiKey { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var lst = new List<string>();

            if (FullActor)
                lst.Add($"{nameof(FullActor)}");
            if (FullCast)
                lst.Add($"{nameof(FullCast)}");
            if (Wikipedia)
                lst.Add($"{nameof(Wikipedia)}");
            if (Posters)
                lst.Add($"{nameof(Posters)}");
            if (Images)
                lst.Add($"{nameof(Images)}");
            if (Trailer)
                lst.Add($"{nameof(Trailer)}");
            if (Ratings)
                lst.Add($"{nameof(Ratings)}");

            sb.Append("{");
            sb.Append(string.Join(",", lst));
            sb.Append("}");

            return sb.ToString();
        }

        public static string OptionsToString(bool FullActor, bool FullCast, bool Wikipedia, bool Posters, bool Images, bool Trailer, bool Ratings)
        {
            var lst = new List<string>();
            if (FullActor)
                lst.Add($"{nameof(FullActor)}");
            if (FullCast)
                lst.Add($"{nameof(FullCast)}");
            if (Wikipedia)
                lst.Add($"{nameof(Wikipedia)}");
            if (Posters)
                lst.Add($"{nameof(Posters)}");
            if (Images)
                lst.Add($"{nameof(Images)}");
            if (Trailer)
                lst.Add($"{nameof(Trailer)}");
            if (Ratings)
                lst.Add($"{nameof(Ratings)}");

            string options = string.Join(",", lst);
            return options;
        }
    }
}
