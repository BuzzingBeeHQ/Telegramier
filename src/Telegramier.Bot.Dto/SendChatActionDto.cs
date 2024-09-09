using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SendChatActionDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("action")]
    public string Action { get; set; }
}
