using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageIdDto
{
    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }
}
