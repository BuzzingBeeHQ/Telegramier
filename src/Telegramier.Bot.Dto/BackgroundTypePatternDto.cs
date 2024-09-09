using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BackgroundTypePatternDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("document")]
    public DocumentDto Document { get; set; }

    [JsonPropertyName("fill")]
    public BackgroundFillDto Fill { get; set; }

    [JsonPropertyName("intensity")]
    public int Intensity { get; set; }

    [JsonPropertyName("is_inverted")]
    public bool? IsInverted { get; set; }

    [JsonPropertyName("is_moving")]
    public bool? IsMoving { get; set; }
}
