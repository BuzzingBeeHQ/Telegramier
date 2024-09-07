using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CloseGeneralForumTopicDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }
}
