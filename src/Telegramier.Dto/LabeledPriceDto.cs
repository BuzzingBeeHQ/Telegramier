using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class LabeledPriceDto
{
    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}
