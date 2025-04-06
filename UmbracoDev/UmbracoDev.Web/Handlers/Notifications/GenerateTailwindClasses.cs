using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using UmbracoDev.Web.Helpers.Css;
using static Umbraco.Cms.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter;

namespace UmbracoDev.Web.Handlers.Notifications;

public class GenerateTailwindClasses : INotificationAsyncHandler<ContentSavedNotification>
{
    private static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        WriteIndented = true
    };

    private readonly string _tailwindOutputPath;
    private readonly ILogger<GenerateTailwindClasses> _logger;

    public GenerateTailwindClasses(ILogger<GenerateTailwindClasses> logger)
    {
        _logger = logger;
        _tailwindOutputPath = Path.Combine($"{Directory.GetCurrentDirectory()}/Styles/", "data.json");
    }

    public async Task HandleAsync(ContentSavedNotification notification, CancellationToken cancellationToken)
    {
        HashSet<string> tailwindClasses = new();

        foreach (var content in notification.SavedEntities)
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

        try
        {
            var json = JsonSerializer.Serialize(tailwindClasses, JsonSerializerOptions);
            await File.WriteAllTextAsync(_tailwindOutputPath, json, cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error writing Tailwind classes to file.");
        }

        return;
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
                        classValue = JsonSerializer.Deserialize<List<string>>(setting.Value)?.FirstOrDefault() ?? string.Empty;
                        break;
                    case JsonValueKind.String when setting.EditorAlias.Equals("Umbraco.ColorPicker"):
                        PickedColor? pickedColor = JsonSerializer.Deserialize<PickedColor>(setting.Value.GetString());
                        classValue = pickedColor is null ? string.Empty : $"[{pickedColor.Color.ToUpper()}]";
                        break;
                    case JsonValueKind.String when setting.EditorAlias.Equals("Umbraco.ColorPicker.EyeDropper"):
                        string eyeDropperColor = JsonSerializer.Deserialize<string>(setting.Value);
                        classValue = string.IsNullOrWhiteSpace(eyeDropperColor) ? string.Empty : $"[{eyeDropperColor.ToUpper()}]";
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