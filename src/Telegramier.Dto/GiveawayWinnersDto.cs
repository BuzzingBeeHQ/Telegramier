using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GiveawayWinnersDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("giveaway_message_id")]
    public int GiveawayMessageId { get; set; }

    [JsonPropertyName("winners_selection_date")]
    public int WinnersSelectionDate { get; set; }

    [JsonPropertyName("winner_count")]
    public int WinnerCount { get; set; }

    [JsonPropertyName("winners")]
    public List<UserDto> Winners { get; set; }

    [JsonPropertyName("additional_chat_count")]
    public int? AdditionalChatCount { get; set; }

    [JsonPropertyName("prize_star_count")]
    public int? PrizeStarCount { get; set; }

    [JsonPropertyName("premium_subscription_month_count")]
    public int? PremiumSubscriptionMonthCount { get; set; }

    [JsonPropertyName("unclaimed_prize_count")]
    public int? UnclaimedPrizeCount { get; set; }

    [JsonPropertyName("only_new_members")]
    public bool? OnlyNewMembers { get; set; }

    [JsonPropertyName("was_refunded")]
    public bool? WasRefunded { get; set; }

    [JsonPropertyName("prize_description")]
    public string? PrizeDescription { get; set; }
}
