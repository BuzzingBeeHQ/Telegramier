using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChatMemberRestrictedDto
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public UserDto User { get; set; }

    [JsonPropertyName("is_member")]
    public bool IsMember { get; set; }

    [JsonPropertyName("can_send_messages")]
    public bool CanSendMessages { get; set; }

    [JsonPropertyName("can_send_audios")]
    public bool CanSendAudios { get; set; }

    [JsonPropertyName("can_send_documents")]
    public bool CanSendDocuments { get; set; }

    [JsonPropertyName("can_send_photos")]
    public bool CanSendPhotos { get; set; }

    [JsonPropertyName("can_send_videos")]
    public bool CanSendVideos { get; set; }

    [JsonPropertyName("can_send_video_notes")]
    public bool CanSendVideoNotes { get; set; }

    [JsonPropertyName("can_send_voice_notes")]
    public bool CanSendVoiceNotes { get; set; }

    [JsonPropertyName("can_send_polls")]
    public bool CanSendPolls { get; set; }

    [JsonPropertyName("can_send_other_messages")]
    public bool CanSendOtherMessages { get; set; }

    [JsonPropertyName("can_add_web_page_previews")]
    public bool CanAddWebPagePreviews { get; set; }

    [JsonPropertyName("can_change_info")]
    public bool CanChangeInfo { get; set; }

    [JsonPropertyName("can_invite_users")]
    public bool CanInviteUsers { get; set; }

    [JsonPropertyName("can_pin_messages")]
    public bool CanPinMessages { get; set; }

    [JsonPropertyName("can_manage_topics")]
    public bool CanManageTopics { get; set; }

    [JsonPropertyName("until_date")]
    public int UntilDate { get; set; }
}
