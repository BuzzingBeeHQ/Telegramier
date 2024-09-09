using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UnbanChatSenderChatDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("sender_chat_id")]
    public int SenderChatId { get; set; }
}
