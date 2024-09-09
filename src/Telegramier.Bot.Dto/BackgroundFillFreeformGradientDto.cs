using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BackgroundFillFreeformGradientDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("colors")]
    public int[] Colors { get; set; }
}
