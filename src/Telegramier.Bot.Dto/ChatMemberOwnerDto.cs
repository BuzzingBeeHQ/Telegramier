using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatMemberOwnerDto
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("is_anonymous")]
    public bool IsAnonymous { get; set; }

    [JsonPropertyName("custom_title")]
    public string? CustomTitle { get; set; }
}
