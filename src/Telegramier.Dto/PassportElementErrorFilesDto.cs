using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportElementErrorFilesDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("file_hashes")]
    public string[] FileHashes { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
