using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotCommandScopeChatMemberDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
