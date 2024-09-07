using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StickerSetDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("sticker_type")]
    public string StickerType { get; set; }

    [JsonPropertyName("stickers")]
    public List<StickerDto> Stickers { get; set; }

    [JsonPropertyName("thumbnail")]
    public PhotoSizeDto? Thumbnail { get; set; }
}
