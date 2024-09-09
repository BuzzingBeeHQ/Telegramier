using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BirthdateDto
{
    [JsonPropertyName("day")]
    public int Day { get; set; }

    [JsonPropertyName("month")]
    public int Month { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }
}
