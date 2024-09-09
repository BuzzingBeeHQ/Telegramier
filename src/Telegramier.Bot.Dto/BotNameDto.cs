using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotNameDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
