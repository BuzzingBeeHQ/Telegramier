using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BusinessConnectionDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("user_chat_id")]
    public long UserChatId { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("can_reply")]
    public bool CanReply { get; set; }

    [JsonPropertyName("is_enabled")]
    public bool IsEnabled { get; set; }
}
