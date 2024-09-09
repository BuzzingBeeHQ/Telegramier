using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InlineQueryResultArticleDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("input_message_content")]
    public InputMessageContentDto InputMessageContent { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("hide_url")]
    public bool? HideUrl { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("thumbnail_width")]
    public int? ThumbnailWidth { get; set; }

    [JsonPropertyName("thumbnail_height")]
    public int? ThumbnailHeight { get; set; }
}
