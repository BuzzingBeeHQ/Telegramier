using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class DeleteStickerFromSetDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }
}
