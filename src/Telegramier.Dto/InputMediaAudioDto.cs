using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InputMediaAudioDto
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

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("performer")]
    public string? Performer { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}
