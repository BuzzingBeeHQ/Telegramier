using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBoostSourceGiveawayDto
{
    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("giveaway_message_id")]
    public int GiveawayMessageId { get; set; }

    [JsonPropertyName("user")]
    public UserDto? User { get; set; }

    [JsonPropertyName("prize_star_count")]
    public int? PrizeStarCount { get; set; }

    [JsonPropertyName("is_unclaimed")]
    public bool? IsUnclaimed { get; set; }
}
