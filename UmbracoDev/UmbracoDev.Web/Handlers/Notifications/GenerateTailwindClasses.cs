using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;

namespace UmbracoDev.Web.Handlers.Notifications;

public class GenerateTailwindClasses : INotificationAsyncHandler<ContentSavedNotification>
{
    private readonly IPublishedContentQuery _publishedContentQuery;
    private readonly IUmbracoContextAccessor _umbracoContextAccessor;
    private readonly IContentService _contentService;

    public GenerateTailwindClasses(IPublishedContentQuery publishedContentQuery, IUmbracoContextAccessor umbracoContextAccessor, IContentService contentService)
    {
        _publishedContentQuery = publishedContentQuery;
        _umbracoContextAccessor = umbracoContextAccessor ?? throw new ArgumentNullException(nameof(umbracoContextAccessor));
        _contentService = contentService;
    }

    public Task HandleAsync(ContentSavedNotification notification, CancellationToken cancellationToken)
    {
        //ToDo: make tailwind great again
        return Task.CompletedTask;
    }
}
