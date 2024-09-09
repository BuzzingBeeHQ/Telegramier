using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetChatDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
