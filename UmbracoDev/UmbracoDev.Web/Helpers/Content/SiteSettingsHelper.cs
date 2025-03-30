using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Content;

public static class SiteSettingsHelper
{
    public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent)
    {
        return publishedContent.Root().Children<SiteSettings>()?.SingleOrDefault();
    }
}
