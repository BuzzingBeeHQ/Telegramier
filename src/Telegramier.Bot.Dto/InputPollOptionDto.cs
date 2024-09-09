using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InputPollOptionDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("text_parse_mode")]
    public string? TextParseMode { get; set; }

    [JsonPropertyName("text_entities")]
    public List<MessageEntityDto>? TextEntities { get; set; }
}
