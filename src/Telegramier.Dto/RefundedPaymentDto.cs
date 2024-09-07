using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class RefundedPaymentDto
{
    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("total_amount")]
    public int TotalAmount { get; set; }

    [JsonPropertyName("invoice_payload")]
    public string InvoicePayload { get; set; }

    [JsonPropertyName("telegram_payment_charge_id")]
    public string TelegramPaymentChargeId { get; set; }

    [JsonPropertyName("provider_payment_charge_id")]
    public string? ProviderPaymentChargeId { get; set; }
}
