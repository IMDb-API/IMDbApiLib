namespace IMDbApiLib
{
    public static class ExtensionMethods
    {
        public static string ToPascalCasting(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (str.Length == 1)
                return str.ToUpperInvariant();

            return $"{str.Substring(0, 1).ToUpperInvariant()}{str.Substring(1)}";
        }

        public static string ToPascalCastingAll(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            if (str.Length == 1)
                return str.ToUpperInvariant();

            string tmp = "";
            foreach (string s in str.Split('-', '_'))
                tmp += s.ToPascalCasting() + " ";

            return tmp.Trim();
        }
    }
}
