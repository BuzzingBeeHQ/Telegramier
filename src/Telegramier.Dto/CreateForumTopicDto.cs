using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CreateForumTopicDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("icon_color")]
    public int? IconColor { get; set; }

    [JsonPropertyName("icon_custom_emoji_id")]
    public string? IconCustomEmojiId { get; set; }
}
