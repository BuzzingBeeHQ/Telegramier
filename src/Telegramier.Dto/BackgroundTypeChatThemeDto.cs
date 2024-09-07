using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BackgroundTypeChatThemeDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("theme_name")]
    public string ThemeName { get; set; }
}
