using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UploadStickerFileDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("sticker")]
    public InputFileDto Sticker { get; set; }

    [JsonPropertyName("sticker_format")]
    public string StickerFormat { get; set; }
}
