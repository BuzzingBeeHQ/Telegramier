using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GameHighScoreDto
{
    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }
}
