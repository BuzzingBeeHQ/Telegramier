using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReplaceStickerInSetDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("old_sticker")]
    public string OldSticker { get; set; }

    [JsonPropertyName("sticker")]
    public InputStickerDto Sticker { get; set; }
}
