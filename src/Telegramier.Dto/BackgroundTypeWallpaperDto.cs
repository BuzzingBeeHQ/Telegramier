using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BackgroundTypeWallpaperDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("document")]
    public DocumentDto Document { get; set; }

    [JsonPropertyName("dark_theme_dimming")]
    public int DarkThemeDimming { get; set; }

    [JsonPropertyName("is_blurred")]
    public bool? IsBlurred { get; set; }

    [JsonPropertyName("is_moving")]
    public bool? IsMoving { get; set; }
}
