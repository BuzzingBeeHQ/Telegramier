using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class UnpinAllChatMessagesDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
