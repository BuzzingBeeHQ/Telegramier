using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PaidMediaPreviewDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
}
