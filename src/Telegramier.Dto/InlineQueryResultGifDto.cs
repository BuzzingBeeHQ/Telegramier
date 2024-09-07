using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultGifDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("gif_url")]
    public string GifUrl { get; set; }

    [JsonPropertyName("gif_width")]
    public int? GifWidth { get; set; }

    [JsonPropertyName("gif_height")]
    public int? GifHeight { get; set; }

    [JsonPropertyName("gif_duration")]
    public int? GifDuration { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonPropertyName("thumbnail_mime_type")]
    public string? ThumbnailMimeType { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("caption_entities")]
    public List<MessageEntityDto>? CaptionEntities { get; set; }

    [JsonPropertyName("show_caption_above_media")]
    public bool? ShowCaptionAboveMedia { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }

    [JsonPropertyName("input_message_content")]
    public InputMessageContentDto? InputMessageContent { get; set; }
}
