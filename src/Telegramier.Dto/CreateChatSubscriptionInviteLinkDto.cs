using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CreateChatSubscriptionInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("subscription_period")]
    public int SubscriptionPeriod { get; set; }

    [JsonPropertyName("subscription_price")]
    public int SubscriptionPrice { get; set; }
}
