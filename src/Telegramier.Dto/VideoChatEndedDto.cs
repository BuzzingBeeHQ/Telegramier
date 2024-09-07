using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class VideoChatEndedDto
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}
