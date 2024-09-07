using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatAdministratorRightsDto
{
    [JsonPropertyName("is_anonymous")]
    public bool IsAnonymous { get; set; }

    [JsonPropertyName("can_manage_chat")]
    public bool CanManageChat { get; set; }

    [JsonPropertyName("can_delete_messages")]
    public bool CanDeleteMessages { get; set; }

    [JsonPropertyName("can_manage_video_chats")]
    public bool CanManageVideoChats { get; set; }

    [JsonPropertyName("can_restrict_members")]
    public bool CanRestrictMembers { get; set; }

    [JsonPropertyName("can_promote_members")]
    public bool CanPromoteMembers { get; set; }

    [JsonPropertyName("can_change_info")]
    public bool CanChangeInfo { get; set; }

    [JsonPropertyName("can_invite_users")]
    public bool CanInviteUsers { get; set; }

    [JsonPropertyName("can_post_stories")]
    public bool CanPostStories { get; set; }

    [JsonPropertyName("can_edit_stories")]
    public bool CanEditStories { get; set; }

    [JsonPropertyName("can_delete_stories")]
    public bool CanDeleteStories { get; set; }

    [JsonPropertyName("can_post_messages")]
    public bool? CanPostMessages { get; set; }

    [JsonPropertyName("can_edit_messages")]
    public bool? CanEditMessages { get; set; }

    [JsonPropertyName("can_pin_messages")]
    public bool? CanPinMessages { get; set; }

    [JsonPropertyName("can_manage_topics")]
    public bool? CanManageTopics { get; set; }
}
