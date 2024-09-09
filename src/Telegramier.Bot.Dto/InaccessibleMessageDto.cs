using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InaccessibleMessageDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }
}
