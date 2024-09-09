using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SendPhotoDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("photo")]
    public object Photo { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("caption_entities")]
    public List<MessageEntityDto>? CaptionEntities { get; set; }

    [JsonPropertyName("show_caption_above_media")]
    public bool? ShowCaptionAboveMedia { get; set; }

    [JsonPropertyName("has_spoiler")]
    public bool? HasSpoiler { get; set; }

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
