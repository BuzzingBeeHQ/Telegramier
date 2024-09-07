using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MessageAutoDeleteTimerChangedDto
{
    [JsonPropertyName("message_auto_delete_time")]
    public int MessageAutoDeleteTime { get; set; }
}
