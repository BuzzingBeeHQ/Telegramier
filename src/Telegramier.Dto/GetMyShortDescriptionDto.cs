using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetMyShortDescriptionDto
{
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
