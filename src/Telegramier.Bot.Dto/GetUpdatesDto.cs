using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetUpdatesDto
{
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("timeout")]
    public int? Timeout { get; set; }

    [JsonPropertyName("allowed_updates")]
    public string[]? AllowedUpdates { get; set; }
}
