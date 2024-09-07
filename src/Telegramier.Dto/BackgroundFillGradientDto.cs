using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BackgroundFillGradientDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("top_color")]
    public int TopColor { get; set; }

    [JsonPropertyName("bottom_color")]
    public int BottomColor { get; set; }

    [JsonPropertyName("rotation_angle")]
    public int RotationAngle { get; set; }
}
