using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class RevenueWithdrawalStateSucceededDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
