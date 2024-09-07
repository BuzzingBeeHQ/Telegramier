using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ProximityAlertTriggeredDto
{
    [JsonPropertyName("traveler")]
    public UserDto Traveler { get; set; }

    [JsonPropertyName("watcher")]
    public UserDto Watcher { get; set; }

    [JsonPropertyName("distance")]
    public int Distance { get; set; }
}
