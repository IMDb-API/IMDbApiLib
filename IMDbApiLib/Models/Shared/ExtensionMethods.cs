using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace IMDbApiLib
{
    public static class ExtensionMethods
    {
        public static bool IsNull(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

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

        public static string GetDescription(this Enum enumValue)
        {
            if (enumValue is null)
                return string.Empty;

            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DescriptionAttribute>()?
                .Description ?? string.Empty;
        }

        public static string GetDisplayName(this Enum enumValue)
        {
            if (enumValue is null)
                return string.Empty;

            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
    }
}
