using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotCommandDto
{
    [JsonPropertyName("command")]
    public string Command { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}
