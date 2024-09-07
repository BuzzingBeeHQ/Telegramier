using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatBackgroundDto
{
    [JsonPropertyName("type")]
    public BackgroundTypeDto Type { get; set; }
}
