using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class EditChatSubscriptionInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("invite_link")]
    public string InviteLink { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
