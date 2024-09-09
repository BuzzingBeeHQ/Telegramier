using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetMyNameDto
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
