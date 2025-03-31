using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;
using static Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter;

namespace UmbracoDev.Web.Helpers.Css;

public static class ThemeHelper
{
    private const string DARK_MODE_PREFIX = "dark:";
    private const string BACKGROUND_PREFIX = "bg";
    private const string TEXT_PREFIX = "text";
    private const string ACCENT_PREFIX = "accent";

    public static string GetThemeCss(this IPublishedContent content)
    {
        if (content is not IThemeProperties themeProperties) return string.Empty;

        List<string> classes =
        [
            ComposeCssClass(BACKGROUND_PREFIX, themeProperties.LightModeBackgroundColor),
            ComposeCssClass(TEXT_PREFIX, themeProperties.LightModeTextColor),
            ComposeCssClass(ACCENT_PREFIX, themeProperties.LightModeAccentColor),
            ComposeCssClass(BACKGROUND_PREFIX, themeProperties.DarkModeBackgroundColor, true),
            ComposeCssClass(TEXT_PREFIX, themeProperties.DarkModeTextColor, true),
            ComposeCssClass(ACCENT_PREFIX, themeProperties.DarkModeAccentColor, true),
        ];

        return string.Join(' ', classes.Where(c => !string.IsNullOrWhiteSpace(c)));
    }

    public static string GetThemeCss(this ContentBlockSettings content)
    {
        if (content is not IThemeProperties themeProperties) return string.Empty;

        List<string> classes =
        [
            ComposeCssClass(BACKGROUND_PREFIX, themeProperties.LightModeBackgroundColor),
            ComposeCssClass(TEXT_PREFIX, themeProperties.LightModeTextColor),
            ComposeCssClass(ACCENT_PREFIX, themeProperties.LightModeAccentColor),
            ComposeCssClass(BACKGROUND_PREFIX, themeProperties.DarkModeBackgroundColor, true),
            ComposeCssClass(TEXT_PREFIX, themeProperties.DarkModeTextColor, true),
            ComposeCssClass(ACCENT_PREFIX, themeProperties.DarkModeAccentColor, true),
        ];

        return string.Join(' ', classes.Where(c => !string.IsNullOrWhiteSpace(c)));
    }

    private static string ComposeCssClass(string type, PickedColor? pickedColor, bool isDarkModeColor = false)
    {
        if (pickedColor is null 
            || string.IsNullOrWhiteSpace(type) 
            || string.IsNullOrWhiteSpace(pickedColor.Color)) 
            return string.Empty;

        return $"{(isDarkModeColor ? DARK_MODE_PREFIX : string.Empty)}{type}-[{pickedColor.Color}]";
    }
}
