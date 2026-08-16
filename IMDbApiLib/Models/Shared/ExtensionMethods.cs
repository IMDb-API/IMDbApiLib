using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace IMDbApiLib;

public static class ExtensionMethods
{
    #region Enums

    public static string GetDescription(this Enum enumValue)
    {
        if (enumValue is null)
        {
            return string.Empty;
        }

        string? description = enumValue.GetType()
            .GetMember(enumValue.ToString())
            .FirstOrDefault()?
            .GetCustomAttribute<DescriptionAttribute>()?
            .Description;

        if (string.IsNullOrEmpty(description))
        {
            description = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()?
                .GetCustomAttribute<DisplayAttribute>()?
                .Description;
        }

        return description ?? string.Empty;
    }

    public static string GetDisplayName(this Enum enumValue, bool fillIfEmpty = true)
    {
        if (enumValue is null)
        {
            return string.Empty;
        }

        string displayName = fillIfEmpty ? enumValue.ToString() : string.Empty;

        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .FirstOrDefault()?
            .GetCustomAttribute<DisplayAttribute>()?
            .GetName() ?? displayName;
    }

    public static string GetGroupName(this Enum enumValue)
    {
        if (enumValue is null)
        {
            return string.Empty;
        }

        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .FirstOrDefault()?
            .GetCustomAttribute<DisplayAttribute>()?
            .GroupName ?? string.Empty;
    }

    public static IEnumerable<T> GetEnumFlags<T>(this T flags) where T : Enum
    {
        foreach (Enum value in Enum.GetValues(flags.GetType()))
        {
            if (flags.HasFlag(value))
            {
                yield return (T)value;
            }
        }
    }
    #endregion
}