namespace Telegramier.Bot.Client.Settings;

public class TelegramierBotSettings
{
    public const string SectionKey = "TelegramierBotSettings";

    public string BotToken { get; set; } = string.Empty;
}