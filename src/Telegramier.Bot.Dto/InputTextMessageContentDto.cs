using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class InputTextMessageContentDto
{
    [JsonPropertyName("message_text")]
    public string MessageText { get; set; }

    [JsonPropertyName("parse_mode")]
    public string? ParseMode { get; set; }

    [JsonPropertyName("entities")]
    public MessageEntityDto[]? Entities { get; set; }

    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptionsDto? LinkPreviewOptions { get; set; }
}
