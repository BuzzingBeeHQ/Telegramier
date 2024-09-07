using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class RestrictChatMemberDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("permissions")]
    public ChatPermissionsDto Permissions { get; set; }

    [JsonPropertyName("use_independent_chat_permissions")]
    public bool? UseIndependentChatPermissions { get; set; }

    [JsonPropertyName("until_date")]
    public int? UntilDate { get; set; }
}
