using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BackgroundFillSolidDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("color")]
    public int Color { get; set; }
}
