using System.Text;
using Umbraco.Cms.Core.Models.PublishedContent;
using static Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter;

namespace UmbracoDev.Web.Helpers.Css;

public static class CssTailwindGeneratorHelper
{
    private const string DEFAULT = "unset";

    public static string GenerateTailwindClasses<T>(this IPublishedElement settings) where T : IPublishedElement
    {
        if (settings is not T) return string.Empty;

        var elementProperties = typeof(T).GetProperties();

        StringBuilder cssBuilder = new();

        foreach (var property in elementProperties)
        {
            object? value = settings.Value(property.Name);

            if (value is null) continue;

            string className = TailwindClassBuilderHelper.ProcessClassNameReplacements(property.Name);

            switch (value)
            {
                case PickedColor pickedColor:
                    cssBuilder.Append($"{className}[{pickedColor.Color}] ");
                    break;
                case string stringValue
                    when !string.IsNullOrWhiteSpace(stringValue)
                        && !stringValue.Equals(DEFAULT, comparisonType: StringComparison.OrdinalIgnoreCase):
                    //cssBuilder.Append($"{ConvertToCssProperty(elementPrefix, property.Name)}:{stringValue.ToLower()}; ");
                    break;
                default:
                    //Console.WriteLine($"Problem with the css generator {value} - {property.Name}");
                    break;
            }
        }

        return cssBuilder.ToString().TrimEnd();
    }
}
