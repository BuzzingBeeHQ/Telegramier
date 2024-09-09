using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ForumTopicEditedDto
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("icon_custom_emoji_id")]
    public string? IconCustomEmojiId { get; set; }
}
