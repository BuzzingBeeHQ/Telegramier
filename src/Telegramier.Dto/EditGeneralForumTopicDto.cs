using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class EditGeneralForumTopicDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
