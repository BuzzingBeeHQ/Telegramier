using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotCommandScopeAllPrivateChatsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
