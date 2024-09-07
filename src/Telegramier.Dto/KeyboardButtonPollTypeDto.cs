using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class KeyboardButtonPollTypeDto
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
