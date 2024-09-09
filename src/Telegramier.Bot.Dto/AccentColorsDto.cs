using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class AccentColorsDto
{
    [JsonPropertyName("color_identifier")]
    public int ColorIdentifier { get; set; }

    [JsonPropertyName("light_colors")]
    public string LightColors { get; set; }

    [JsonPropertyName("dark_colors")]
    public string DarkColors { get; set; }
}
