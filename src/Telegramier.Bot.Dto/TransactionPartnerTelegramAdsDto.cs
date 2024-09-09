using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class TransactionPartnerTelegramAdsDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
