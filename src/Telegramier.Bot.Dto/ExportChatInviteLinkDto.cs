using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ExportChatInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }
}
