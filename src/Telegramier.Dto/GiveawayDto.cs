using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GiveawayDto
{
    [JsonPropertyName("chats")]
    public ChatDto[] Chats { get; set; }

    [JsonPropertyName("winners_selection_date")]
    public int WinnersSelectionDate { get; set; }

    [JsonPropertyName("winner_count")]
    public int WinnerCount { get; set; }

    [JsonPropertyName("only_new_members")]
    public bool? OnlyNewMembers { get; set; }

    [JsonPropertyName("has_public_winners")]
    public bool? HasPublicWinners { get; set; }

    [JsonPropertyName("prize_description")]
    public string? PrizeDescription { get; set; }

    [JsonPropertyName("country_codes")]
    public string[]? CountryCodes { get; set; }

    [JsonPropertyName("prize_star_count")]
    public int? PrizeStarCount { get; set; }

    [JsonPropertyName("premium_subscription_month_count")]
    public int? PremiumSubscriptionMonthCount { get; set; }
}
