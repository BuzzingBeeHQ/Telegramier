using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetStickerKeywordsDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("keywords")]
    public string[]? Keywords { get; set; }
}
