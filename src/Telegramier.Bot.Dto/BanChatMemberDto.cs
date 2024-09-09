using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class BanChatMemberDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("until_date")]
    public int? UntilDate { get; set; }

    [JsonPropertyName("revoke_messages")]
    public bool? RevokeMessages { get; set; }
}
