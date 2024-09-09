using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatBackgroundDto
{
    [JsonPropertyName("type")]
    public BackgroundTypeDto Type { get; set; }
}
