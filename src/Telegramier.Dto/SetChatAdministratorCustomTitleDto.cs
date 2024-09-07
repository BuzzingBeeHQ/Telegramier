using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetChatAdministratorCustomTitleDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("custom_title")]
    public string CustomTitle { get; set; }
}
