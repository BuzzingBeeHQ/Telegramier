using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetStickerMaskPositionDto
{
    [JsonPropertyName("sticker")]
    public string Sticker { get; set; }

    [JsonPropertyName("mask_position")]
    public MaskPositionDto? MaskPosition { get; set; }
}
