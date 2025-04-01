using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoDev.Web.Helpers.Css;

public static class ContentBlockStyleHelper
{
    private const string JUSTIFY_SELF = "justify-self";
    private const string ALIGN_SELF = "align-self";

    private static readonly Dictionary<string, string> PropertyNameToCssElement = new()
    {
        { "JustifySelf", JUSTIFY_SELF },
        { "AlignSelf", ALIGN_SELF }
    };

    public static string GetStyle(this IPublishedElement settings)
    {
        if (settings is null) return string.Empty;

        StringBuilder stringBuilder = new();

        foreach ((string propertyName, string cssElement) in PropertyNameToCssElement)
        {
            string? value = settings.Value<string>(propertyName);

            if (string.IsNullOrWhiteSpace(value)) continue;

            stringBuilder.Append($"{cssElement}:{value}; ");
        }

        return stringBuilder.ToString();
    }
}
