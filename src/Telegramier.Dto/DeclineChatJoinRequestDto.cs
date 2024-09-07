using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeclineChatJoinRequestDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; } // Integer or String

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
