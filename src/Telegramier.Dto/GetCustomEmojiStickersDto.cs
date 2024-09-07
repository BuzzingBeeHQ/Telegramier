using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetCustomEmojiStickersDto
{
    [JsonPropertyName("custom_emoji_ids")]
    public string[] CustomEmojiIds { get; set; }
}
