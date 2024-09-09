using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SendMessageDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; } = default!;

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("entities")]
    public List<MessageEntityDto>? Entities { get; set; }

    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptionsDto? LinkPreviewOptions { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    [JsonPropertyName("reply_parameters")]
    public ReplyParametersDto? ReplyParameters { get; set; }

    [JsonPropertyName("reply_markup")]
    public object? ReplyMarkup { get; set; }
}
