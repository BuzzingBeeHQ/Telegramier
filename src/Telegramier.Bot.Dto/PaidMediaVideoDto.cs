using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PaidMediaVideoDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("video")]
    public VideoDto Video { get; set; }
}
