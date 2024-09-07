using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CreateNewStickerSetDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("stickers")]
    public List<InputStickerDto> Stickers { get; set; }

    [JsonPropertyName("sticker_type")]
    public string? StickerType { get; set; }

    [JsonPropertyName("needs_repainting")]
    public bool? NeedsRepainting { get; set; }
}
