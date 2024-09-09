using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageOriginHiddenUserDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("sender_user_name")]
    public string SenderUserName { get; set; }
}
