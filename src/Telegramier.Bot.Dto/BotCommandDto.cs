using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotCommandDto
{
    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}
