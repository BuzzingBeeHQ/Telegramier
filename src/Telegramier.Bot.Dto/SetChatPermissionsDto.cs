using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetChatPermissionsDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("permissions")]
    public ChatPermissionsDto Permissions { get; set; }

    [JsonPropertyName("use_independent_chat_permissions")]
    public bool? UseIndependentChatPermissions { get; set; }
}
