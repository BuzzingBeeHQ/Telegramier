using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class LocationDto
{
    [JsonPropertyName("latitude")]
    public float Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public float Longitude { get; set; }

    [JsonPropertyName("horizontal_accuracy")]
    public float? HorizontalAccuracy { get; set; }

    [JsonPropertyName("live_period")]
    public int? LivePeriod { get; set; }

    [JsonPropertyName("heading")]
    public int? Heading { get; set; }

    [JsonPropertyName("proximity_alert_radius")]
    public int? ProximityAlertRadius { get; set; }
}
