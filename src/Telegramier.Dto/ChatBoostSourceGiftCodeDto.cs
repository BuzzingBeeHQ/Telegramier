using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatBoostSourceGiftCodeDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }
}
