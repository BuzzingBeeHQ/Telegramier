using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class DeleteMyCommandsDto
{
    [JsonPropertyName("scope")]
    public BotCommandScopeDto? Scope { get; set; }

    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
