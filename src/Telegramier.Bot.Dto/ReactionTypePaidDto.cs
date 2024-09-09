using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ReactionTypePaidDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
