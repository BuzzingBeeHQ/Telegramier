using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ForumTopicCreatedDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("icon_color")]
    public int IconColor { get; set; }

    [JsonPropertyName("icon_custom_emoji_id")]
    public string? IconCustomEmojiId { get; set; }
}
