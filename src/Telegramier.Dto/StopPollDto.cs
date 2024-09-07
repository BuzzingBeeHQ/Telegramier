using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StopPollDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
