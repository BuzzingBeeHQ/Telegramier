using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MessageReactionCountUpdatedDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("reactions")]
    public List<ReactionCountDto> Reactions { get; set; }
}
