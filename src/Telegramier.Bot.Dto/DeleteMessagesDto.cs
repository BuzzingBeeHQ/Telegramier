using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class DeleteMessagesDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; } // Can be either Integer or String

    [JsonPropertyName("message_ids")]
    public int[] MessageIds { get; set; }
}
