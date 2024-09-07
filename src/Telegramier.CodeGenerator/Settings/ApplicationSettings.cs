namespace Telegramier.CodeGenerator.Settings;

public class ApplicationSettings
{
    public const string SettingsKey = "ApplicationSettings";

    public string TelegramBotApiDocumentationUrl { get; set; } = string.Empty;
    public string NamespaceName { get; set; } = string.Empty;
    public string OutputDirectoryPath { get; set; } = string.Empty;
    public OpenAiSettings OpenAiSettings { get; set; } = new();
}