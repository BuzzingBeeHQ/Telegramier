using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotDescriptionDto
{
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
