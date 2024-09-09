using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetStickerMaskPositionDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("mask_position")]
    public MaskPositionDto? MaskPosition { get; set; }
}
