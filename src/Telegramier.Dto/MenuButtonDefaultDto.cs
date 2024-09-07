using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MenuButtonDefaultDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
