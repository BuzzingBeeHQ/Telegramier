using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReactionCountDto
{
    [JsonPropertyName("type")]
    public ReactionTypeDto Type { get; set; }

    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }
}
