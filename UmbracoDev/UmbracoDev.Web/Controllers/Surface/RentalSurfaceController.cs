using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoDev.Web.Models.View;
using Udi = Umbraco.Cms.Core.Udi;

namespace UmbracoDev.Web.Controllers.Surface;

public class RentalSurfaceController : SurfaceController
{
    private readonly IContentService _contentService;
    private readonly IMemberManager _memberManager;
    private readonly MediaFileManager _mediaFileManager;
    private readonly IMediaService _mediaService;
    private readonly IShortStringHelper _shortStringHelper;
    private readonly IContentTypeBaseServiceProvider _contentTypeBaseServiceProvider;
    private readonly MediaUrlGeneratorCollection _mediaUrlGeneratorCollection;
    private readonly IPublishedContentTypeCache _publishedContentTypeCache;

    public RentalSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services, AppCaches appCaches,
        IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, IContentService contentService, IMemberManager memberManager, 
        MediaFileManager mediaFileManager, IMediaService mediaService, IShortStringHelper shortStringHelper, IContentTypeBaseServiceProvider contentTypeBaseServiceProvider,
        MediaUrlGeneratorCollection mediaUrlGeneratorCollection, IPublishedContentTypeCache publishedContentTypeCache)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _contentService = contentService;
        _memberManager = memberManager;
        _mediaFileManager = mediaFileManager;
        _mediaService = mediaService;
        _shortStringHelper = shortStringHelper;
        _contentTypeBaseServiceProvider = contentTypeBaseServiceProvider;
        _mediaUrlGeneratorCollection = mediaUrlGeneratorCollection;
        _publishedContentTypeCache = publishedContentTypeCache;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SubmitItem(RentalViewModel model)
    {
        if (!ModelState.IsValid)
        {
            // Handle validation errors and return to the form with errors
            TempData["Error"] = "Please fill in all required fields.";
            return CurrentUmbracoPage();
        }

        // Ensure the member is authenticated
        var currentMember = await _memberManager.GetCurrentMemberAsync();

        if (currentMember == null)
        {
            TempData["Error"] = "You must be logged in to submit an item.";
            return RedirectToCurrentUmbracoPage();
        }

        // Create a new content node under a specific parent (e.g., Items Folder)
        // Adjust the parent id accordingly, such as the id of an "Items" folder node
        IContent newItem = _contentService.Create(model.itemTitle, Guid.Parse("c81f6d24-4ac4-43df-8506-c9a8b27dcdaf"), "rental");

        // Set the properties
        newItem.SetValue(Rental.GetModelPropertyType(_publishedContentTypeCache, x => x.Title).Alias, model.itemTitle);
        newItem.SetValue(Rental.GetModelPropertyType(_publishedContentTypeCache, x => x.Description).Alias, model.itemDescription);
        newItem.SetValue(Rental.GetModelPropertyType(_publishedContentTypeCache, x => x.Price).Alias, model.itemPrice);
        newItem.SetValue(Rental.GetModelPropertyType(_publishedContentTypeCache, x => x.AddedBy).Alias, currentMember?.UserName);

        var mediaItemIds = new List<Udi>();

        foreach (var file in model.GalleryImages)
        {
            using Stream stream = file.OpenReadStream();

            // TODO: CREATE/GET the folder for images dynamically
            IMedia media = _mediaService.CreateMedia("rental", Guid.Parse("52afec7c-7184-440b-9998-059618b3e6cf"), Constants.Conventions.MediaTypes.Image);

            // Set the property value (Umbraco will handle the underlying magic)
            media.SetValue(_mediaFileManager, _mediaUrlGeneratorCollection, _shortStringHelper, _contentTypeBaseServiceProvider,
                Constants.Conventions.Media.File, file.FileName, stream);

            // Save the media
            var result = _mediaService.Save(media);

            if (result.Success)
            {
                mediaItemIds.Add(Udi.Create(Constants.UdiEntityType.Media, media.Key));
            }
        }

        newItem.SetValue(Rental.GetModelPropertyType(_publishedContentTypeCache, x => x.Gallery).Alias, string.Join(", ", mediaItemIds));

        // Save and keep the item unpublished (pending moderation)
        _contentService.Save(newItem);
        TempData["Success"] = "Your item has been submitted and is pending approval.";

        // Redirect to the same page or a confirmation page
        return RedirectToCurrentUmbracoPage();
    }
}
