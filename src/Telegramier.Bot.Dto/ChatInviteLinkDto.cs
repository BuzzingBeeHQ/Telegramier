using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatInviteLinkDto
{
    [JsonPropertyName("invite_link")]
    public string InviteLink { get; set; }

    [JsonPropertyName("creator")]
    public UserDto Creator { get; set; }

    [JsonPropertyName("creates_join_request")]
    public bool CreatesJoinRequest { get; set; }

    [JsonPropertyName("is_primary")]
    public bool IsPrimary { get; set; }

    [JsonPropertyName("is_revoked")]
    public bool IsRevoked { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("expire_date")]
    public int? ExpireDate { get; set; }

    [JsonPropertyName("member_limit")]
    public int? MemberLimit { get; set; }

    [JsonPropertyName("pending_join_request_count")]
    public int? PendingJoinRequestCount { get; set; }

    [JsonPropertyName("subscription_period")]
    public int? SubscriptionPeriod { get; set; }

    [JsonPropertyName("subscription_price")]
    public int? SubscriptionPrice { get; set; }
}
