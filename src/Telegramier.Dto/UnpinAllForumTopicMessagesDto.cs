using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class UnpinAllForumTopicMessagesDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int MessageThreadId { get; set; }
}
