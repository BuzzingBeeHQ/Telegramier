using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotCommandScopeDefaultDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
