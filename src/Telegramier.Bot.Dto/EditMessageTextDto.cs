using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class EditMessageTextDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object? ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int? MessageId { get; set; }

    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("entities")]
    public List<MessageEntityDto>? Entities { get; set; }

    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptionsDto? LinkPreviewOptions { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
