using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InvoiceDto
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("start_parameter")]
    public string StartParameter { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }
}
