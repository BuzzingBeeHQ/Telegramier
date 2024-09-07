using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class UserChatBoostsDto
{
    [JsonPropertyName("boosts")]
    public ChatBoostDto[] Boosts { get; set; }
}
