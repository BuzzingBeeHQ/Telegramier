using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetChatMenuButtonDto
{
    [JsonPropertyName("chat_id")]
    public int? ChatId { get; set; }
}
