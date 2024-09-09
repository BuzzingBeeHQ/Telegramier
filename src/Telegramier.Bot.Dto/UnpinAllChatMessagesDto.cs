using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UnpinAllChatMessagesDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
