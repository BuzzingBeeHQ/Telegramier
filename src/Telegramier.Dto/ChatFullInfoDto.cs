using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ChatFullInfoDto
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("is_forum")]
    public bool? IsForum { get; set; }

    [JsonPropertyName("accent_color_id")]
    public int AccentColorId { get; set; }

    [JsonPropertyName("max_reaction_count")]
    public int MaxReactionCount { get; set; }

    [JsonPropertyName("photo")]
    public ChatPhotoDto? Photo { get; set; }

    [JsonPropertyName("active_usernames")]
    public List<string>? ActiveUsernames { get; set; }

    [JsonPropertyName("birthdate")]
    public BirthdateDto? Birthdate { get; set; }

    [JsonPropertyName("business_intro")]
    public BusinessIntroDto? BusinessIntro { get; set; }

    [JsonPropertyName("business_location")]
    public BusinessLocationDto? BusinessLocation { get; set; }

    [JsonPropertyName("business_opening_hours")]
    public BusinessOpeningHoursDto? BusinessOpeningHours { get; set; }

    [JsonPropertyName("personal_chat")]
    public ChatDto? PersonalChat { get; set; }

    [JsonPropertyName("available_reactions")]
    public List<ReactionTypeDto>? AvailableReactions { get; set; }

    [JsonPropertyName("background_custom_emoji_id")]
    public string? BackgroundCustomEmojiId { get; set; }

    [JsonPropertyName("profile_accent_color_id")]
    public int? ProfileAccentColorId { get; set; }

    [JsonPropertyName("profile_background_custom_emoji_id")]
    public string? ProfileBackgroundCustomEmojiId { get; set; }

    [JsonPropertyName("emoji_status_custom_emoji_id")]
    public string? EmojiStatusCustomEmojiId { get; set; }

    [JsonPropertyName("emoji_status_expiration_date")]
    public int? EmojiStatusExpirationDate { get; set; }

    [JsonPropertyName("bio")]
    public string? Bio { get; set; }

    [JsonPropertyName("has_private_forwards")]
    public bool? HasPrivateForwards { get; set; }

    [JsonPropertyName("has_restricted_voice_and_video_messages")]
    public bool? HasRestrictedVoiceAndVideoMessages { get; set; }

    [JsonPropertyName("join_to_send_messages")]
    public bool? JoinToSendMessages { get; set; }

    [JsonPropertyName("join_by_request")]
    public bool? JoinByRequest { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("invite_link")]
    public string? InviteLink { get; set; }

    [JsonPropertyName("pinned_message")]
    public MessageDto? PinnedMessage { get; set; }

    [JsonPropertyName("permissions")]
    public ChatPermissionsDto? Permissions { get; set; }

    [JsonPropertyName("can_send_paid_media")]
    public bool? CanSendPaidMedia { get; set; }

    [JsonPropertyName("slow_mode_delay")]
    public int? SlowModeDelay { get; set; }

    [JsonPropertyName("unrestrict_boost_count")]
    public int? UnrestrictBoostCount { get; set; }

    [JsonPropertyName("message_auto_delete_time")]
    public int? MessageAutoDeleteTime { get; set; }

    [JsonPropertyName("has_aggressive_anti_spam_enabled")]
    public bool? HasAggressiveAntiSpamEnabled { get; set; }

    [JsonPropertyName("has_hidden_members")]
    public bool? HasHiddenMembers { get; set; }

    [JsonPropertyName("has_protected_content")]
    public bool? HasProtectedContent { get; set; }

    [JsonPropertyName("has_visible_history")]
    public bool? HasVisibleHistory { get; set; }

    [JsonPropertyName("sticker_set_name")]
    public string? StickerSetName { get; set; }

    [JsonPropertyName("can_set_sticker_set")]
    public bool? CanSetStickerSet { get; set; }

    [JsonPropertyName("custom_emoji_sticker_set_name")]
    public string? CustomEmojiStickerSetName { get; set; }

    [JsonPropertyName("linked_chat_id")]
    public long? LinkedChatId { get; set; }

    [JsonPropertyName("location")]
    public ChatLocationDto? Location { get; set; }
}
