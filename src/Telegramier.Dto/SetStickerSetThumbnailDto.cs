using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetStickerSetThumbnailDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }
}
