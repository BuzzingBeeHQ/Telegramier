using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BotDescriptionDto
{
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
