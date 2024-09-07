using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultVenueDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("latitude")]
    public float Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public float Longitude { get; set; }

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

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }

    [JsonPropertyName("input_message_content")]
    public InputMessageContentDto? InputMessageContent { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("thumbnail_width")]
    public int? ThumbnailWidth { get; set; }

    [JsonPropertyName("thumbnail_height")]
    public int? ThumbnailHeight { get; set; }
}
