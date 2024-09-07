using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SendGameDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public int ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("game_short_name")]
    public string GameShortName { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    [JsonPropertyName("reply_parameters")]
    public ReplyParametersDto? ReplyParameters { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
