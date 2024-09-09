using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class RefundStarPaymentDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("telegram_payment_charge_id")]
    public string TelegramPaymentChargeId { get; set; }
}
