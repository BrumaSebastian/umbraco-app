using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoDev.Web.Helpers.Css;

public static class AlignStyleHelper
{
    private static readonly Dictionary<string, string> PropertyNameToCssElement = new()
    {
        { "AlignSelf", CssElements.ALIGN_SELF },
        { "AlignContent", CssElements.ALIGN_CONTENT },
        { "AlignItems", CssElements.ALIGN_ITEMS },
    };

    public static string GeAlignmentStyle(this IPublishedElement settings)
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
