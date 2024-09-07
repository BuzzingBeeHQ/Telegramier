using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotCommandScopeChatAdministratorsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }
}
