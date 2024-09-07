using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportElementErrorTranslationFileDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("file_hash")]
    public string FileHash { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
