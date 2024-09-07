using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotCommandScopeAllGroupChatsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
