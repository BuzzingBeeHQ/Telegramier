using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PinChatMessageDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }
}
