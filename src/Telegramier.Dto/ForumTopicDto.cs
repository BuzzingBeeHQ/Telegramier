using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ForumTopicDto
{
    [JsonPropertyName("message_thread_id")]
    public int MessageThreadId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("icon_color")]
    public int IconColor { get; set; }

    [JsonPropertyName("icon_custom_emoji_id")]
    public string? IconCustomEmojiId { get; set; }
}
