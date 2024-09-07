using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GiveawayCreatedDto
{
    [JsonPropertyName("prize_star_count")]
    public int? PrizeStarCount { get; set; }
}
