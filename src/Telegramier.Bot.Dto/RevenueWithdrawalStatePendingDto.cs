using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class RevenueWithdrawalStatePendingDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
