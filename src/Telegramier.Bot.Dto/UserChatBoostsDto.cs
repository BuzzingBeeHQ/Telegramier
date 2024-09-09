using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UserChatBoostsDto
{
    [JsonPropertyName("boosts")]
    public ChatBoostDto[] Boosts { get; set; }
}
