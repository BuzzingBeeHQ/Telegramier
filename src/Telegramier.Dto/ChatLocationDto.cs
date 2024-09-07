using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatLocationDto
{
    [JsonPropertyName("location")]
    public LocationDto Location { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }
}
