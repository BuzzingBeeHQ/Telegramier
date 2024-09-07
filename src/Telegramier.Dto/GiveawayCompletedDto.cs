using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GiveawayCompletedDto
{
    [JsonPropertyName("winner_count")]
    public int WinnerCount { get; set; }

    [JsonPropertyName("unclaimed_prize_count")]
    public int? UnclaimedPrizeCount { get; set; }

    [JsonPropertyName("giveaway_message")]
    public MessageDto? GiveawayMessage { get; set; }

    [JsonPropertyName("is_star_giveaway")]
    public bool? IsStarGiveaway { get; set; }
}
