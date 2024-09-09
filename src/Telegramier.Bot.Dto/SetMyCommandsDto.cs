using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetMyCommandsDto
{
    [JsonPropertyName("commands")]
    public BotCommandDto[] Commands { get; set; }

    [JsonPropertyName("scope")]
    public BotCommandScopeDto? Scope { get; set; }

    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; set; }
}
