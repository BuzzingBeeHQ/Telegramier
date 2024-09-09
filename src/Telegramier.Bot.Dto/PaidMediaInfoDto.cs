using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PaidMediaInfoDto
{
    [JsonPropertyName("star_count")]
    public int StarCount { get; set; }

    [JsonPropertyName("paid_media")]
    public PaidMediaDto[] PaidMedia { get; set; }
}
