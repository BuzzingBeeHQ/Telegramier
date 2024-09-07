using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultLocationDto
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

    [JsonPropertyName("horizontal_accuracy")]
    public float? HorizontalAccuracy { get; set; }

    [JsonPropertyName("live_period")]
    public int? LivePeriod { get; set; }

    [JsonPropertyName("heading")]
    public int? Heading { get; set; }

    [JsonPropertyName("proximity_alert_radius")]
    public int? ProximityAlertRadius { get; set; }

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
