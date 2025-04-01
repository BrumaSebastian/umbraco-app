using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class JustifyStyleHelper
{
    private static readonly Dictionary<string, string> PropertyNameToCssElement = new()
    {
        { "JustifySelf", CssElements.JUSTIFY_SELF },
        { "JustifyContent", CssElements.JUSTIFY_CONTENT},
        { "JustifyItems", CssElements.JUSTIFY_ITEMS},
    };

    public static string GetJustifyStyle(this IPublishedElement settings)
    {
        if (settings is not IJustifySelfProperties) return string.Empty;

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
