using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetUserChatBoostsDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
