using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InputMediaDocumentDto
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

    [JsonPropertyName("disable_content_type_detection")]
    public bool? DisableContentTypeDetection { get; set; }
}
