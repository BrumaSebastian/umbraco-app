using Newtonsoft.Json;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;

namespace UmbracoDev.Web.Handlers.Notifications;

public class GenerateTailwindClasses : INotificationAsyncHandler<ContentSavedNotification>
{
    private const string TAILWIND_PREFIX = "tw";

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

                var blockItems = JsonConvert.DeserializeObject<BlockItem>(value);
                var tailwindSettings = blockItems?.SettingsData
                    .SelectMany(sd => sd.Values)
                    .Where(sd => sd.Alias.StartsWith(TAILWIND_PREFIX))
                    .ToList();

                ConstructTailwindClasses(tailwindSettings, tailwindClasses);
            }
        }

        var jsonObject = JsonConvert.SerializeObject(tailwindClasses, Formatting.Indented);
        string filePath = Path.Combine($"{Directory.GetCurrentDirectory()}/Styles/", "data.json");
        await File.WriteAllTextAsync(filePath, jsonObject);

        return;
    }

    private static void ConstructTailwindClasses(List<Setting> tailwindSettings, HashSet<string> tailwindClasses)
    {
        foreach (var setting in tailwindSettings)
        {
            string className = setting.Alias.TrimStart(TAILWIND_PREFIX);
            string classValue = string.Empty;

            switch (setting.Value)
            {
                case string value when setting.EditorAlias.Equals("Umbraco.DropDown.Flexible"):
                    classValue = JsonConvert.DeserializeObject<List<string>>(value)?.FirstOrDefault() ?? string.Empty;
                    break;
                case string value:
                    classValue = value;
                    break;
                default:
                    break;
            }

            if (string.IsNullOrWhiteSpace(classValue)) continue;

            string tailwindClass = $"{className}-{classValue}";
            tailwindClasses.Add(tailwindClass.ToLower());
        }
    }
}

public class BlockItem
{
    public List<SettingsData> SettingsData { get; set; }
}

public class SettingsData
{
    public List<Setting> Values { get; set; }
}

public class Setting
{
    public string EditorAlias { get; set; }
    public string Alias { get; set; }
    public string Value { get; set; }
}
