using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetCustomEmojiStickersDto
{
    [JsonPropertyName("custom_emoji_ids")]
    public string[] CustomEmojiIds { get; set; }
}
