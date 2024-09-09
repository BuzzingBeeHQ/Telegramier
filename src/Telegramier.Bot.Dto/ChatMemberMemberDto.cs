using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatMemberMemberDto
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("until_date")]
    public int? UntilDate { get; set; }
}
