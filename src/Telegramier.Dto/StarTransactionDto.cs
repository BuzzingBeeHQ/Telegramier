using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StarTransactionDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("source")]
    public TransactionPartnerDto? Source { get; set; }

    [JsonPropertyName("receiver")]
    public TransactionPartnerDto? Receiver { get; set; }
}
