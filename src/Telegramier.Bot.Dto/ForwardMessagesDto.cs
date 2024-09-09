using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ForwardMessagesDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("from_chat_id")]
    public string FromChatId { get; set; }

    [JsonPropertyName("message_ids")]
    public int[] MessageIds { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }
}
