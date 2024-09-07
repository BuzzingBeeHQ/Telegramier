using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class StoryDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
