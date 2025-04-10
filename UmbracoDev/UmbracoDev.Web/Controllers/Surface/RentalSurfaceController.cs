using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using UmbracoDev.Web.Models.View;

namespace UmbracoDev.Web.Controllers.Surface;

public class RentalSurfaceController : SurfaceController
{
    private readonly IContentService _contentService;

    public RentalSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services, AppCaches appCaches,
        IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, IContentService contentService)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _contentService = contentService;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SubmitItem(RentalViewModel model)
    {
        if (!ModelState.IsValid)
        {
            // Handle validation errors and return to the form with errors
            TempData["Error"] = "Please fill in all required fields.";
            return CurrentUmbracoPage();
        }

        //// Ensure the member is authenticated
        //var currentMember = Members.GetCurrentMember();
        //if (currentMember == null)
        //{
        //    TempData["Error"] = "You must be logged in to submit an item.";
        //    return RedirectToCurrentUmbracoPage();
        //}

        // Create a new content node under a specific parent (e.g., Items Folder)
        // Adjust the parent id accordingly, such as the id of an "Items" folder node
        IContent newItem = _contentService.Create(model.itemTitle, Guid.Parse("c81f6d24-4ac4-43df-8506-c9a8b27dcdaf"), "rental");

        // Set the properties
        newItem.SetValue("title", model.itemTitle);
        newItem.SetValue("description", model.itemDescription);
        newItem.SetValue("price", model.itemPrice);
        //newItem.SetValue("memberId", "sdf");

        // Handle file uploads (this is a simplified example)
        // Note: File upload handling may differ based on your implementation and security requirements.
        //if (Request.Files.Count > 0)
        //{
        //    // For the preview image (assuming first file is the preview)
        //    HttpPostedFileBase previewFile = Request.Files["previewImage"];
        //    if (previewFile != null && previewFile.ContentLength > 0)
        //    {
        //        // Save the file to Umbraco's media section and set the media id as the property value.
        //        // This requires a custom implementation for handling file upload to media.
        //        int mediaId = SaveFileToMedia(previewFile, "previewImageFolder");
        //        newItem.SetValue("previewImage", mediaId);
        //    }

        //    // For gallery images (if multiple files are uploaded)
        //    // This sample demonstrates concatenating media IDs (e.g., comma separated)
        //    var galleryIds = "";
        //    HttpFileCollectionBase galleryFiles = Request.Files.GetMultiple("galleryImages");
        //    foreach (string key in galleryFiles)
        //    {
        //        HttpPostedFileBase file = galleryFiles[key];
        //        if (file != null && file.ContentLength > 0)
        //        {
        //            int mediaId = SaveFileToMedia(file, "galleryImageFolder");
        //            galleryIds += mediaId + ",";
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(galleryIds))
        //    {
        //        // Remove trailing comma
        //        galleryIds = galleryIds.TrimEnd(',');
        //        newItem.SetValue("galleryImages", galleryIds);
        //    }
        //}

        // Save and keep the item unpublished (pending moderation)
        _contentService.Save(newItem);
        TempData["Success"] = "Your item has been submitted and is pending approval.";

        // Redirect to the same page or a confirmation page
        return RedirectToCurrentUmbracoPage();
    }

    //// Dummy helper method for saving files to media.
    //// In a real implementation, you would create and save media items properly.
    //private int SaveFileToMedia(HttpPostedFileBase file, string folder)
    //{
    //    // Your logic to save the file in Umbraco's media library,
    //    // then return the media item id.
    //    // For example, you might use the MediaService to create a media item.
    //    return 0;
    //}
}
