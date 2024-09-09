using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetStarTransactionsDto
{
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
