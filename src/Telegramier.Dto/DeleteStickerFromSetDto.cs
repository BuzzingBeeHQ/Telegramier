using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeleteStickerFromSetDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }
}
