using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class LinkPreviewOptionsDto
{
    [JsonPropertyName("is_disabled")]
    public bool? IsDisabled { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("prefer_small_media")]
    public bool? PreferSmallMedia { get; set; }

    [JsonPropertyName("prefer_large_media")]
    public bool? PreferLargeMedia { get; set; }

    [JsonPropertyName("show_above_text")]
    public bool? ShowAboveText { get; set; }
}
