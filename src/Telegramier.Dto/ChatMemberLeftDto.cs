using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatMemberLeftDto
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }
}
