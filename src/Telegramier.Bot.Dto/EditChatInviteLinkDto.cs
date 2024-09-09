using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class EditChatInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("invite_link")]
    public string InviteLink { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("expire_date")]
    public int? ExpireDate { get; set; }

    [JsonPropertyName("member_limit")]
    public int? MemberLimit { get; set; }

    [JsonPropertyName("creates_join_request")]
    public bool? CreatesJoinRequest { get; set; }
}
