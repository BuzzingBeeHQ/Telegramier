using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class AnswerShippingQueryDto
{
    [JsonPropertyName("shipping_query_id")]
    public string ShippingQueryId { get; set; }

    [JsonPropertyName("ok")]
    public bool Ok { get; set; }

    [JsonPropertyName("shipping_options")]
    public ShippingOptionDto[]? ShippingOptions { get; set; }

    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }
}
