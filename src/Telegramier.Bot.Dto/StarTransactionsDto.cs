using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class StarTransactionsDto
{
    [JsonPropertyName("transactions")]
    public StarTransactionDto[] Transactions { get; set; }
}
