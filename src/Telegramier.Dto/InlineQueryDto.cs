using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }

    [JsonPropertyName("offset")]
    public string Offset { get; set; }

    [JsonPropertyName("chat_type")]
    public string? ChatType { get; set; }

    [JsonPropertyName("location")]
    public LocationDto? Location { get; set; }
}
