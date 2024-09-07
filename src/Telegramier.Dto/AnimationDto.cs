using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class AnimationDto
{
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }

    [JsonPropertyName("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("thumbnail")]
    public PhotoSizeDto? Thumbnail { get; set; }

    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    [JsonPropertyName("mime_type")]
    public string? MimeType { get; set; }

    [JsonPropertyName("file_size")]
    public int? FileSize { get; set; }
}
