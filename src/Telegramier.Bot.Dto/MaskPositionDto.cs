using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MaskPositionDto
{
    [JsonPropertyName("point")]
    public string Point { get; set; }

    [JsonPropertyName("x_shift")]
    public float XShift { get; set; }

    [JsonPropertyName("y_shift")]
    public float YShift { get; set; }

    [JsonPropertyName("scale")]
    public float Scale { get; set; }
}
