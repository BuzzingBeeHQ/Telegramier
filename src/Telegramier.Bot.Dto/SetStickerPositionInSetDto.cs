using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetStickerPositionInSetDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }
}
