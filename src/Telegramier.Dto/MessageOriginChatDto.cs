using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MessageOriginChatDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("sender_chat")]
    public ChatDto SenderChat { get; set; }

    [JsonPropertyName("author_signature")]
    public string? AuthorSignature { get; set; }
}
