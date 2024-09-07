using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatMemberBannedDto
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("until_date")]
    public int UntilDate { get; set; }
}
