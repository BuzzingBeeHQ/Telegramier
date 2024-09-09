using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class VideoChatEndedDto
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}
