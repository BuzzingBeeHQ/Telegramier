using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportElementErrorUnspecifiedDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("element_hash")]
    public string ElementHash { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
