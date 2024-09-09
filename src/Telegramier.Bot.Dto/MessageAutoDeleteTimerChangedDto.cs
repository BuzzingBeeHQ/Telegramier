using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageAutoDeleteTimerChangedDto
{
    [JsonPropertyName("message_auto_delete_time")]
    public int MessageAutoDeleteTime { get; set; }
}
