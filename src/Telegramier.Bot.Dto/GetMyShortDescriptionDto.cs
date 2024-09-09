using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetMyShortDescriptionDto
{
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
