using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetCustomEmojiStickerSetThumbnailDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("custom_emoji_id")]
    public string? CustomEmojiId { get; set; }
}
