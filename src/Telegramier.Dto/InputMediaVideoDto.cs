using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InputMediaVideoDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("media")]
    public string Media { get; set; }

    [JsonPropertyName("thumbnail")]
    public string? Thumbnail { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("caption_entities")]
    public List<MessageEntityDto>? CaptionEntities { get; set; }

    [JsonPropertyName("show_caption_above_media")]
    public bool? ShowCaptionAboveMedia { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("supports_streaming")]
    public bool? SupportsStreaming { get; set; }

    [JsonPropertyName("has_spoiler")]
    public bool? HasSpoiler { get; set; }
}
