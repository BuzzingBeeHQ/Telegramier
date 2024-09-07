using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReactionTypePaidDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
