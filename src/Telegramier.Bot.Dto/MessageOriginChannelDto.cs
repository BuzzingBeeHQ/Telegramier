using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageOriginChannelDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("author_signature")]
    public string? AuthorSignature { get; set; }
}
