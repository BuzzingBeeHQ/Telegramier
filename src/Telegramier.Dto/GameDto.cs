using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GameDto
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[] Photo { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("text_entities")]
    public MessageEntityDto[]? TextEntities { get; set; }

    [JsonPropertyName("animation")]
    public AnimationDto? Animation { get; set; }
}
