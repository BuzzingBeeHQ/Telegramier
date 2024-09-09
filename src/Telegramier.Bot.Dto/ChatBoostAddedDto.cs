using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostAddedDto
{
    [JsonPropertyName("boost_count")]
    public int BoostCount { get; set; }
}
