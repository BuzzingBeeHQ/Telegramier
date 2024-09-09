using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class VenueDto
{
    [JsonPropertyName("location")]
    public LocationDto Location { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("foursquare_id")]
    public string? FoursquareId { get; set; }

    [JsonPropertyName("foursquare_type")]
    public string? FoursquareType { get; set; }

    [JsonPropertyName("google_place_id")]
    public string? GooglePlaceId { get; set; }

    [JsonPropertyName("google_place_type")]
    public string? GooglePlaceType { get; set; }
}
