using Org.BouncyCastle.Asn1.X509.Qualified;
using Umbraco.Cms.Core;
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

    public static void GetContainerCss(this IPublishedElement settings)
    {
        if (settings is not IContainerStylingProperties containerStylingProperties) return;

        var containerProperties = typeof(IContainerStylingProperties).GetProperties();
    }
}
