using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BotNameDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
