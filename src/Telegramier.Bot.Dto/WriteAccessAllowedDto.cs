using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class WriteAccessAllowedDto
{
    [JsonPropertyName("from_request")]
    public bool? FromRequest { get; set; }

    [JsonPropertyName("web_app_name")]
    public string? WebAppName { get; set; }

    [JsonPropertyName("from_attachment_menu")]
    public bool? FromAttachmentMenu { get; set; }
}
