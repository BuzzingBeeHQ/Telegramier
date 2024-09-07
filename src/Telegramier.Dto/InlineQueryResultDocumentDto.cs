using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultDocumentDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("caption_entities")]
    public List<MessageEntityDto>? CaptionEntities { get; set; }

    [JsonPropertyName("document_url")]
    public string DocumentUrl { get; set; }

    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
