using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetStarTransactionsDto
{
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
