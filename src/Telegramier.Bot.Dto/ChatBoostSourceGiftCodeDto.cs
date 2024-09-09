using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostSourceGiftCodeDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }
}
