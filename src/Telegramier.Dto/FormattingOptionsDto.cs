using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class FormattingOptionsDto
{
    [JsonPropertyName("parse_mode")]
    public string ParseMode { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
