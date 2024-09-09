using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class VideoChatScheduledDto
{
    [JsonPropertyName("start_date")]
    public int StartDate { get; set; }
}
