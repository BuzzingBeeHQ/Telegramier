using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetMyDescriptionDto
{
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
