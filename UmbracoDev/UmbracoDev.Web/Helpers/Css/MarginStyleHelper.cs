using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class MarginStyleHelper
{
    private static readonly Dictionary<string, string> PropertyNameToCssElement = new()
    {
        { "MarginLeft", CssElements.MARGIN_LEFT },
        { "MarginRight", CssElements.MARGIN_RIGHT },
        { "MarginTop", CssElements.MARGIN_TOP },
        { "MarginBottom", CssElements.MARGIN_BOTTOM }
    };

    public static string GetMarginStyle(this IPublishedElement settings)
    {
        if (settings is not IMarginProperties) return string.Empty;

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
