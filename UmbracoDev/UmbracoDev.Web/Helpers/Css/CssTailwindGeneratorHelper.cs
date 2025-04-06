using System.Reflection;
using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class CssTailwindGeneratorHelper
{
    public static string GenerateTailwindClasses<T>(this IPublishedElement settings) where T : IPublishedElement
    {
        if (settings is not T) return string.Empty;

        var elementProperties = PrepareProperties<T>(typeof(T).GetProperties(), settings);

        StringBuilder classBuilder = new();

        foreach (var property in elementProperties)
        {
            object? value = settings.Value(property.Name);

            if (value is null || string.IsNullOrWhiteSpace(value.ToString())) continue;

            string className = TailwindClassBuilderHelper.ProcessClassNameReplacements(property.Name);
            string classValue = TailwindClassBuilderHelper.GetClassValue(value);

            if (string.IsNullOrWhiteSpace(classValue)) continue;

            classBuilder.Append($"{className}{classValue} ");
        }

        return classBuilder.ToString().TrimEnd();
    }

    private static PropertyInfo[] PrepareProperties<T>(PropertyInfo[] props, IPublishedElement instance)
    {
        var propertiesToRemove = new HashSet<string>();

        if (instance is ITwThemeProperties themeProps)
        {
            FilterThemeProperties(themeProps, propertiesToRemove);
        }

        return [.. props.Where(p => p.PropertyType != typeof(bool) && !propertiesToRemove.Contains(p.Name))];
    }

    private static void FilterThemeProperties(ITwThemeProperties themeProps, HashSet<string> toRemove)
    {
        toRemove.Add(themeProps.LightModeBackground
            ? nameof(themeProps.TwLightModePresetBackgroundColor)
            : nameof(themeProps.TwLightModeCustomBackgroundColor));

        toRemove.Add(themeProps.LightModeText
            ? nameof(themeProps.TwLightModePresetTextColor)
            : nameof(themeProps.TwLightModeCustomTextColor));

        toRemove.Add(themeProps.LightModeAccent
            ? nameof(themeProps.TwLightModePresetAccentColor)
            : nameof(themeProps.TwLightModeCustomAccentColor));

        toRemove.Add(themeProps.DarkModeBackground
            ? nameof(themeProps.TwDarkModePresetBackgroundColor)
            : nameof(themeProps.TwDarkModeCustomBackgroundColor));

        toRemove.Add(themeProps.DarkModeText
            ? nameof(themeProps.TwDarkModePresetTextColor)
            : nameof(themeProps.TwDarkModeCustomTextColor));

        toRemove.Add(themeProps.DarkModeAccent
            ? nameof(themeProps.TwDarkModePresetAccentColor)
            : nameof(themeProps.TwDarkModeCustomAccentColor));
    }
}
