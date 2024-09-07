using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MessageIdDto
{
    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }
}
