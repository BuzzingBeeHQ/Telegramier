using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatMemberUpdatedDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("old_chat_member")]
    public ChatMemberDto OldChatMember { get; set; }

    [JsonPropertyName("new_chat_member")]
    public ChatMemberDto NewChatMember { get; set; }

    [JsonPropertyName("invite_link")]
    public ChatInviteLinkDto? InviteLink { get; set; }

    [JsonPropertyName("via_join_request")]
    public bool? ViaJoinRequest { get; set; }

    [JsonPropertyName("via_chat_folder_invite_link")]
    public bool? ViaChatFolderInviteLink { get; set; }
}
