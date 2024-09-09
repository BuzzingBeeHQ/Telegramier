using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class CreateChatInviteLinkDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("expire_date")]
    public int? ExpireDate { get; set; }

    [JsonPropertyName("member_limit")]
    public int? MemberLimit { get; set; }

    [JsonPropertyName("creates_join_request")]
    public bool? CreatesJoinRequest { get; set; }
}
