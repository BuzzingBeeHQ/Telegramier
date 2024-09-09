using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class OrderInfoDto
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("shipping_address")]
    public ShippingAddressDto? ShippingAddress { get; set; }
}
