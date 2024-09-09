using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class TransactionPartnerOtherDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
