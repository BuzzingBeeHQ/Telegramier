using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageOriginUserDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("sender_user")]
    public UserDto SenderUser { get; set; }
}
