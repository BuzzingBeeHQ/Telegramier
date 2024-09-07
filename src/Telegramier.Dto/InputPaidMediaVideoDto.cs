using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InputPaidMediaVideoDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("media")]
    public string Media { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("supports_streaming")]
    public bool? SupportsStreaming { get; set; }
}
