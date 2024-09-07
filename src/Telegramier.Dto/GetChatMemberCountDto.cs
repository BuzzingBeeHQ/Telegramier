using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetChatMemberCountDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
