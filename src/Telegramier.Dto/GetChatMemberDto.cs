using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetChatMemberDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; } // Can be either Integer or String

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
