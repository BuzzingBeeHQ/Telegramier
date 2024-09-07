using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class VideoChatScheduledDto
{
    [JsonPropertyName("start_date")]
    public int StartDate { get; set; }
}
