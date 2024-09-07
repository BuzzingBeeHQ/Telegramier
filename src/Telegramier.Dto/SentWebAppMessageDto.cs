using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SentWebAppMessageDto
{
    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }
}
