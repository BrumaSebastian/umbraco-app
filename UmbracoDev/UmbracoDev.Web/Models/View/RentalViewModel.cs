namespace UmbracoDev.Web.Models.View;

public class RentalViewModel
{
    public string itemTitle { get; set; }
    public string itemDescription { get; set; }
    public decimal itemPrice { get; set; }
    public List<IFormFile> GalleryImages { get; set; }
}
