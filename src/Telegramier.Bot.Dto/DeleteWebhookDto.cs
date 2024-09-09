using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class DeleteWebhookDto
{
    [JsonPropertyName("drop_pending_updates")]
    public bool? DropPendingUpdates { get; set; }
}
