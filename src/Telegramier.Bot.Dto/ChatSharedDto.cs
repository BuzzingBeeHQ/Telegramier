using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatSharedDto
{
    [JsonPropertyName("request_id")]
    public int RequestId { get; set; }

    [JsonPropertyName("chat_id")]
    public long ChatId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[]? Photo { get; set; }
}
