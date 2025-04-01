using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class PaddingStyleHelper
{
    private static readonly Dictionary<string, string> PropertyNameToCssElement = new()
    {
        { "PaddingLeft", CssElements.PADDING_LEFT },
        { "PaddingRight", CssElements.PADDING_RIGHT },
        { "PaddingTop", CssElements.PADDING_TOP },
        { "PaddingBottom", CssElements.PADDING_BOTTOM }
    };

    public static string GetPaddingStyle(this IPublishedElement settings)
    {
        if (settings is not IPaddingProperties) return string.Empty;

        StringBuilder stringBuilder = new();

        foreach ((string propertyName, string cssElement) in PropertyNameToCssElement)
        {
            int value = settings.Value<int>(propertyName);

            if (value <= 0) continue;

            stringBuilder.Append($"{cssElement}:calc(var(--spacing)*{value}); ");
        }

        return stringBuilder.ToString().TrimEnd();
    }
}
