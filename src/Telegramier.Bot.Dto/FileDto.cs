using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class FileDto
{
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }

    [JsonPropertyName("file_unique_id")]
    public string FileUniqueId { get; set; }

    [JsonPropertyName("file_size")]
    public int? FileSize { get; set; }

    [JsonPropertyName("file_path")]
    public string? FilePath { get; set; }
}
