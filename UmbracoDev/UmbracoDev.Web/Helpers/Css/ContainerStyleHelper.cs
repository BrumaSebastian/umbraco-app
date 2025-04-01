using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class ContainerStyleHelper
{
    private static readonly Dictionary<string, string> SpacingElements = new()
    {
        { "ContainerMarginLeft", CssElements.MARGIN_LEFT },
        { "ContainerMarginRight", CssElements.MARGIN_RIGHT },
        { "ContainerMarginTop", CssElements.MARGIN_TOP },
        { "ContainerMarginBottom", CssElements.MARGIN_BOTTOM },
        { "ContainerPaddingLeft", CssElements.PADDING_LEFT },
        { "ContainerPaddingRight", CssElements.PADDING_RIGHT },
        { "ContainerPaddingTop", CssElements.PADDING_TOP },
        { "ContainerPaddingBottom", CssElements.PADDING_BOTTOM }
    };

    private static readonly Dictionary<string, string> AlignmentElements = new()
    {
        { "ContainerJustifyContent", CssElements.JUSTIFY_CONTENT },
        { "ContainerAlignItems", CssElements.ALIGN_ITEMS }
    };

    public static string GetAlignmentStyling(this IPublishedElement settings) 
        => settings.GenerateCss(AlignmentElements, value => value);

    public static string GetCalculatedSpacingStyling(this IPublishedElement settings)
        => settings.GenerateCss(SpacingElements, value => $"calc(var(--spacing) * {value})");

    private static string GenerateCss(this IPublishedElement settings, Dictionary<string, string> properties, Func<string, string> formatValue)
    {
        if (settings is not IContainerStylingProperties) return string.Empty;

        StringBuilder cssBuilder = new();

        foreach (var (propertyName, cssElement) in properties)
        {
            var value = settings.Value<string>(propertyName);
            if (string.IsNullOrWhiteSpace(value)) continue;

            cssBuilder.Append($"{cssElement}:{formatValue(value)}; ");
        }

        return cssBuilder.ToString().TrimEnd();
    }
}
