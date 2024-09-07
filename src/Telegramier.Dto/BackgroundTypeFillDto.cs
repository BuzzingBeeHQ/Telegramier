using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BackgroundTypeFillDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("fill")]
    public BackgroundFillDto Fill { get; set; }

    [JsonPropertyName("dark_theme_dimming")]
    public int DarkThemeDimming { get; set; }
}
