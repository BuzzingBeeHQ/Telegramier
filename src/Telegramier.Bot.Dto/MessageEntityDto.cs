using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageEntityDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("user")]
    public UserDto? User { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("custom_emoji_id")]
    public string? CustomEmojiId { get; set; }
}
