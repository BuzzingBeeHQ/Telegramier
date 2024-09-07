using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetMyNameDto
{
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
