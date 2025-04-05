namespace UmbracoDev.Web.Helpers.Css;

public static class TailwindClassBuilderHelper
{
    public const string TAILWIND_PREFIX = "tw";

    public static Dictionary<string, string> PropertyNameToTailwindClass = new()
    {
        { "LightMode", "" },
        { "DarkMode", "dark:" },
        { "BackgroundColor", "bg-" },
        { "AccentColor", "accent-" },
        { "TextColor", "text-" },
    };

    public static List<string> CustomKeywords = [
        "Preset",
        "Custom"
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
}
