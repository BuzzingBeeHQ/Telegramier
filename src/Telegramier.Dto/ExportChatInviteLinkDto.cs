using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ExportChatInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }
}
