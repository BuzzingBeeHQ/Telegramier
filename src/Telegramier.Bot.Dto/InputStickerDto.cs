using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InputStickerDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("emoji_list")]
    public List<string> EmojiList { get; set; }

    [JsonPropertyName("mask_position")]
    public MaskPositionDto? MaskPosition { get; set; }

    [JsonPropertyName("keywords")]
    public List<string>? Keywords { get; set; }
}
