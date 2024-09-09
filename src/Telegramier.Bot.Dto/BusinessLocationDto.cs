using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BusinessLocationDto
{
    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("location")]
    public LocationDto? Location { get; set; }
}
