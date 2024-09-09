using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatJoinRequestDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("user_chat_id")]
    public long UserChatId { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("bio")]
    public string? Bio { get; set; }

    [JsonPropertyName("invite_link")]
    public ChatInviteLinkDto? InviteLink { get; set; }
}
