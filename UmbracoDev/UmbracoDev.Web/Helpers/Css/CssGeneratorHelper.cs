using System.Text;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoDev.Web.Helpers.Css;

public static class CssGeneratorHelper
{
    private const string DEFAULT = "unset";
    public static string GenerateCss<T>(this IPublishedElement settings, string elementPrefix = "") where T : IPublishedElement
    {
        if (settings is not T) return string.Empty;

        var elementProperties = typeof(T).GetProperties();

        StringBuilder cssBuilder = new();

        foreach (var property in elementProperties)
        {
            object? value = settings.Value(property.Name);

            if (value is null) continue;

            switch (value)
            {
                case int intValue when intValue > 0:
                    cssBuilder.Append($"{ConvertToCssProperty(elementPrefix, property.Name)}:calc(var(--spacing)*{intValue}); ");
                    break;
                case string stringValue 
                    when !string.IsNullOrWhiteSpace(stringValue) 
                        && !stringValue.Equals(DEFAULT, comparisonType: StringComparison.OrdinalIgnoreCase):
                    cssBuilder.Append($"{ConvertToCssProperty(elementPrefix, property.Name)}:{stringValue.ToLower()}; ");
                    break;
                case MediaWithCrops<Image> image when image is not null:
                    cssBuilder.Append($"{ConvertToCssProperty(elementPrefix, property.Name)}:url({image.GetCropUrl()}); ");
                    break;
                default:
                    //Console.WriteLine($"Problem with the css generator {value} - {property.Name}");
                    break;
            }
        }

        return cssBuilder.ToString().TrimEnd();
    }

    public static string ConvertToCssProperty(string prefix, string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return string.Empty;

        var formatedInput = input.TrimStart(prefix);
        return string.Concat(formatedInput.Select((c, i) => i > 0 && char.IsUpper(c) ? "-" + char.ToLower(c) : char.ToLower(c).ToString()));
    }
}
