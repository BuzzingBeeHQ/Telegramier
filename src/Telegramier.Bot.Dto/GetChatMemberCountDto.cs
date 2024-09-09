using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetChatMemberCountDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
