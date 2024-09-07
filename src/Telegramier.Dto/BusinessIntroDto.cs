using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BusinessIntroDto
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("sticker")]
    public StickerDto? Sticker { get; set; }
}
