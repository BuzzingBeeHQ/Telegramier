using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetGameHighScoresDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("chat_id")]
    public int? ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int? MessageId { get; set; }

    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }
}
