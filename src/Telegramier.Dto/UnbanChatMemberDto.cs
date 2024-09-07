using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class UnbanChatMemberDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("only_if_banned")]
    public bool? OnlyIfBanned { get; set; }
}
