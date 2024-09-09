using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class TransactionPartnerUserDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("invoice_payload")]
    public string? InvoicePayload { get; set; }

    [JsonPropertyName("paid_media")]
    public List<PaidMediaDto>? PaidMedia { get; set; }

    [JsonPropertyName("paid_media_payload")]
    public string? PaidMediaPayload { get; set; }
}
