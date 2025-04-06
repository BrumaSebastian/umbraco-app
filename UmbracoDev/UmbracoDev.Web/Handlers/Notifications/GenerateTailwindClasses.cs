using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Services;
using UmbracoDev.Web.Helpers.Css;
using static Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter;

namespace UmbracoDev.Web.Handlers.Notifications;

public class GenerateTailwindClasses : INotificationAsyncHandler<ContentSavedNotification>
{
    private readonly IContentService _contentService;

    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        WriteIndented = true
    };

    private readonly string _tailwindOutputPath;
    private readonly ILogger<GenerateTailwindClasses> _logger;

    public GenerateTailwindClasses(ILogger<GenerateTailwindClasses> logger, IContentService contentService)
    {
        _logger = logger;
        _tailwindOutputPath = Path.Combine($"{Directory.GetCurrentDirectory()}/Styles/", "data.json");
        _contentService = contentService;
    }

    public async Task HandleAsync(ContentSavedNotification notification, CancellationToken cancellationToken)
    {
        var rootContent = _contentService.GetRootContent().ToList();
        List<IContent> allContentNodes = new();

        foreach (var root in rootContent)
        {
            allContentNodes.Add(root);
            allContentNodes.AddRange(GetAllDescendants(_contentService, root.Id));
        }

        HashSet<string> tailwindClasses = new();

        // Construct Site Settings
        var siteSettings = allContentNodes.SingleOrDefault(n => n.ContentType.Alias == "siteSettings");
        var siteTailwindProperties = siteSettings?.Properties
         .Where(p => p.Alias.StartsWith(TailwindClassBuilderHelper.TAILWIND_PREFIX) && p.GetValue() is not null).ToList();

        foreach (var property in siteTailwindProperties)
        {
            string classValue = string.Empty;

            if (property.PropertyType.PropertyEditorAlias == "Umbraco.ColorPicker")
            {
                classValue = TailwindClassBuilderHelper.GetClassValue(JsonSerializer.Deserialize<PickedColor>(property.GetValue().ToString()));
            }
            else
            {
                classValue = TailwindClassBuilderHelper.GetClassValue(property.GetValue());
            }

            tailwindClasses.Add($"{TailwindClassBuilderHelper.ProcessClassNameReplacements(property.Alias)}{classValue}");
        }

        // Construct Blocks
        foreach (var content in allContentNodes)
        {
            var contentProperties = content.Properties
                .Where(p => p.PropertyType.PropertyEditorAlias == "Umbraco.BlockGrid"
                    || p.PropertyType.PropertyEditorAlias == "Umbraco.BlockList");

            foreach (var property in contentProperties)
            {
                var value = property.GetValue()?.ToString();

                if (string.IsNullOrWhiteSpace(value)) continue;

                var blockItems = JsonSerializer.Deserialize<BlockItem>(value);
                var tailwindSettings = blockItems?.SettingsData
                     .SelectMany(sd => sd.Properties)
                     .Where(settingsElement => settingsElement.Alias.StartsWith(TailwindClassBuilderHelper.TAILWIND_PREFIX))
                     .ToList();

                if (tailwindSettings is null || tailwindSettings.Count == 0) continue;

                ConstructTailwindClasses(tailwindSettings, tailwindClasses);
            }
        }

        await WriteTailwindClassesToFile(tailwindClasses, cancellationToken).ConfigureAwait(false);

        return;
    }

    private IEnumerable<IContent> GetAllDescendants(IContentService contentService, int parentId)
    {
        const int pageSize = 100;
        int pageIndex = 0;
        long totalRecords;
        var results = new List<IContent>();

        do
        {
            var page = contentService.GetPagedDescendants(parentId, pageIndex, pageSize, out totalRecords);
            results.AddRange(page);
            pageIndex++;
        }
        while (results.Count < totalRecords);

        return results;
    }

    private async Task WriteTailwindClassesToFile(HashSet<string> tailwindClasses, CancellationToken cancellationToken)
    {
        try
        {
            var json = JsonSerializer.Serialize(tailwindClasses, JsonSerializerOptions);
            await System.IO.File.WriteAllTextAsync(_tailwindOutputPath, json, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error writing Tailwind classes to file.");
        }
    }

    private static void ConstructTailwindClasses(IEnumerable<SettingsElement> tailwindSettings, HashSet<string> tailwindClasses)
    {
        foreach (var setting in tailwindSettings)
        {
            string className = TailwindClassBuilderHelper.ProcessClassNameReplacements(setting.Alias);
            string classValue = string.Empty;

            try
            {
                switch (setting.Value.ValueKind)
                {
                    case JsonValueKind.String when setting.EditorAlias.Equals("Umbraco.DropDown.Flexible"):
                        classValue = JsonSerializer.Deserialize<string[]>(setting.Value.GetString())[0].ToLower() ?? string.Empty;
                        break;
                    case JsonValueKind.String when setting.EditorAlias.Equals("Umbraco.ColorPicker"):
                        PickedColor? pickedColor = JsonSerializer.Deserialize<PickedColor>(setting.Value.GetString());
                        classValue = pickedColor is null ? string.Empty : $"[{pickedColor.Color.ToUpper()}]";
                        break;
                    case JsonValueKind.String when setting.EditorAlias.Equals("Umbraco.ColorPicker.EyeDropper"):
                        string eyeDropperColor = JsonSerializer.Deserialize<string>(setting.Value);
                        classValue = string.IsNullOrWhiteSpace(eyeDropperColor) ? string.Empty : $"[{eyeDropperColor.ToUpper()}]";
                        break;
                    case JsonValueKind.String:
                        classValue = setting.Value.ToString();
                        break;
                    case JsonValueKind.Number:
                        classValue = setting.Value.ToString();
                        break;
                    
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            if (string.IsNullOrWhiteSpace(classValue)) continue;

            tailwindClasses.Add($"{className}{classValue}");
        }
    }
}

public class BlockItem
{
    [JsonPropertyName("settingsData")]
    public List<PropertySettings> SettingsData { get; init; }
}

public class PropertySettings
{
    [JsonPropertyName("values")]
    public List<SettingsElement> Properties { get; init; }
}

public class SettingsElement
{
    [JsonPropertyName("editorAlias")]
    public string EditorAlias { get; init; }
    [JsonPropertyName("alias")]
    public string Alias { get; init; }
    [JsonPropertyName("value")]
    public JsonElement Value { get; init; }
}