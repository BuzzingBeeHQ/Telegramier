using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatLocationDto
{
    [JsonPropertyName("location")]
    public LocationDto Location { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }
}
