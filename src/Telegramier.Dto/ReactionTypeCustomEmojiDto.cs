using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReactionTypeCustomEmojiDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("custom_emoji_id")]
    public string CustomEmojiId { get; set; }
}
