using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StarTransactionsDto
{
    [JsonPropertyName("transactions")]
    public StarTransactionDto[] Transactions { get; set; }
}
