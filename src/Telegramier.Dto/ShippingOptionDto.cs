using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ShippingOptionDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("prices")]
    public List<LabeledPriceDto> Prices { get; set; }
}
