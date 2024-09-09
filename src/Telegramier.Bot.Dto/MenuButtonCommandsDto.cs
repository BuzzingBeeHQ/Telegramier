using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MenuButtonCommandsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
