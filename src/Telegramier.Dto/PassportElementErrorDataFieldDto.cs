using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportElementErrorDataFieldDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("field_name")]
    public string FieldName { get; set; }

    [JsonPropertyName("data_hash")]
    public string DataHash { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
