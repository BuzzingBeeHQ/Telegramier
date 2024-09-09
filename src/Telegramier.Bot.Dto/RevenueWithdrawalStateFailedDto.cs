using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class RevenueWithdrawalStateFailedDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
