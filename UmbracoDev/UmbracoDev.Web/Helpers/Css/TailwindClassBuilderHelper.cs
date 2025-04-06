using static Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter;

namespace UmbracoDev.Web.Helpers.Css;

public static class TailwindClassBuilderHelper
{
    public const string TAILWIND_PREFIX = "tw";
    private const string DEFAULT = "unset";

    public static Dictionary<string, string> PropertyNameToTailwindClass = new()
    {
        { "LightMode", "" },
        { "DarkMode", "dark:" },
        { "BackgroundColor", "bg-" },
        { "AccentColor", "accent-" },
        { "TextColor", "text-" },
        { "PaddingBottom", "pb-" },
        { "PaddingTop", "pt-" },
        { "PaddingLeft", "pl-" },
        { "PaddingRight", "pr-" },
        { "MarginBottom", "mb-" },
        { "MarginTop", "mt-" },
        { "MarginLeft", "ml-" },
        { "MarginRight", "mr-" },
        { "Gap", "gap-" },
    };

    public static List<string> CustomKeywords = [
        "Preset",
        "Custom",
        "Layout"
    ];

    public static string ProcessClassNameReplacements(string propertyAlias)
    {
        string className = propertyAlias.TrimStart(TAILWIND_PREFIX);
        className = RemoveCustomKeywords(className);
        className = ReplacePropertyNameWithTailwindClasses(className);

        return className;
    }

    private static string RemoveCustomKeywords(string className)
    {
        foreach (var keyword in CustomKeywords)
        {
            className = className.Replace(keyword, "", StringComparison.InvariantCultureIgnoreCase);
        }

        return className;
    }

    private static string ReplacePropertyNameWithTailwindClasses(string className)
    {
        foreach ((string propertyName, string tailwindClass) in PropertyNameToTailwindClass)
        {
            if (className.Contains(propertyName, StringComparison.InvariantCultureIgnoreCase))
            {
                className = className.Replace(propertyName, tailwindClass, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        return className;
    }

    public static string GetClassValue(object value)
    {
        string classValue = string.Empty;

        switch (value)
        {
            case PickedColor pickedColor:
                classValue = $"[{pickedColor.Color}]";
                break;
            case string stringValue when stringValue.StartsWith('#'):
                classValue = $"[{stringValue}]";
                break;
            case string stringValue when !stringValue.Equals(DEFAULT, comparisonType: StringComparison.OrdinalIgnoreCase):
                classValue = $"[{stringValue}]";
                break;
            case int intValue when intValue > 0:
                classValue = $"{intValue}";
                break;

            default:
                //Console.WriteLine($"Problem with the css generator {value} - {property.Name}");
                break;
        }

        return classValue;
    }
}
