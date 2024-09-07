using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class HideGeneralForumTopicDto
{
    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; } // Integer or String
}
