using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ShippingQueryDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("invoice_payload")]
    public string InvoicePayload { get; set; }

    [JsonPropertyName("shipping_address")]
    public ShippingAddressDto ShippingAddress { get; set; }
}
