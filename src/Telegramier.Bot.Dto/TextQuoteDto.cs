using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class TextQuoteDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("entities")]
    public MessageEntityDto[]? Entities { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("is_manual")]
    public bool? IsManual { get; set; }
}
