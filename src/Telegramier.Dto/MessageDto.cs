using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MessageDto
{
    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("from")]
    public UserDto? From { get; set; }

    [JsonPropertyName("sender_chat")]
    public ChatDto? SenderChat { get; set; }

    [JsonPropertyName("sender_boost_count")]
    public int? SenderBoostCount { get; set; }

    [JsonPropertyName("sender_business_bot")]
    public UserDto? SenderBusinessBot { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("forward_origin")]
    public MessageOriginDto? ForwardOrigin { get; set; }

    [JsonPropertyName("is_topic_message")]
    public bool? IsTopicMessage { get; set; }

    [JsonPropertyName("is_automatic_forward")]
    public bool? IsAutomaticForward { get; set; }

    [JsonPropertyName("reply_to_message")]
    public MessageDto? ReplyToMessage { get; set; }

    [JsonPropertyName("external_reply")]
    public ExternalReplyInfoDto? ExternalReply { get; set; }

    [JsonPropertyName("quote")]
    public TextQuoteDto? Quote { get; set; }

    [JsonPropertyName("reply_to_story")]
    public StoryDto? ReplyToStory { get; set; }

    [JsonPropertyName("via_bot")]
    public UserDto? ViaBot { get; set; }

    [JsonPropertyName("edit_date")]
    public int? EditDate { get; set; }

    [JsonPropertyName("has_protected_content")]
    public bool? HasProtectedContent { get; set; }

    [JsonPropertyName("is_from_offline")]
    public bool? IsFromOffline { get; set; }

    [JsonPropertyName("media_group_id")]
    public string? MediaGroupId { get; set; }

    [JsonPropertyName("author_signature")]
    public string? AuthorSignature { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("entities")]
    public MessageEntityDto[]? Entities { get; set; }

    [JsonPropertyName("link_preview_options")]
    public LinkPreviewOptionsDto? LinkPreviewOptions { get; set; }

    [JsonPropertyName("effect_id")]
    public string? EffectId { get; set; }

    [JsonPropertyName("animation")]
    public AnimationDto? Animation { get; set; }

    [JsonPropertyName("audio")]
    public AudioDto? Audio { get; set; }

    [JsonPropertyName("document")]
    public DocumentDto? Document { get; set; }

    [JsonPropertyName("paid_media")]
    public PaidMediaInfoDto? PaidMedia { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[]? Photo { get; set; }

    [JsonPropertyName("sticker")]
    public StickerDto? Sticker { get; set; }

    [JsonPropertyName("story")]
    public StoryDto? Story { get; set; }

    [JsonPropertyName("video")]
    public VideoDto? Video { get; set; }

    [JsonPropertyName("video_note")]
    public VideoNoteDto? VideoNote { get; set; }

    [JsonPropertyName("voice")]
    public VoiceDto? Voice { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }

    [JsonPropertyName("caption_entities")]
    public MessageEntityDto[]? CaptionEntities { get; set; }

    [JsonPropertyName("show_caption_above_media")]
    public bool? ShowCaptionAboveMedia { get; set; }

    [JsonPropertyName("has_media_spoiler")]
    public bool? HasMediaSpoiler { get; set; }

    [JsonPropertyName("contact")]
    public ContactDto? Contact { get; set; }

    [JsonPropertyName("dice")]
    public DiceDto? Dice { get; set; }

    [JsonPropertyName("game")]
    public GameDto? Game { get; set; }

    [JsonPropertyName("poll")]
    public PollDto? Poll { get; set; }

    [JsonPropertyName("venue")]
    public VenueDto? Venue { get; set; }

    [JsonPropertyName("location")]
    public LocationDto? Location { get; set; }

    [JsonPropertyName("new_chat_members")]
    public UserDto[]? NewChatMembers { get; set; }

    [JsonPropertyName("left_chat_member")]
    public UserDto? LeftChatMember { get; set; }

    [JsonPropertyName("new_chat_title")]
    public string? NewChatTitle { get; set; }

    [JsonPropertyName("new_chat_photo")]
    public PhotoSizeDto[]? NewChatPhoto { get; set; }

    [JsonPropertyName("delete_chat_photo")]
    public bool? DeleteChatPhoto { get; set; }

    [JsonPropertyName("group_chat_created")]
    public bool? GroupChatCreated { get; set; }

    [JsonPropertyName("supergroup_chat_created")]
    public bool? SupergroupChatCreated { get; set; }

    [JsonPropertyName("channel_chat_created")]
    public bool? ChannelChatCreated { get; set; }

    [JsonPropertyName("message_auto_delete_timer_changed")]
    public MessageAutoDeleteTimerChangedDto? MessageAutoDeleteTimerChanged { get; set; }

    [JsonPropertyName("migrate_to_chat_id")]
    public long? MigrateToChatId { get; set; }

    [JsonPropertyName("migrate_from_chat_id")]
    public long? MigrateFromChatId { get; set; }

    [JsonPropertyName("pinned_message")]
    public MaybeInaccessibleMessageDto? PinnedMessage { get; set; }

    [JsonPropertyName("invoice")]
    public InvoiceDto? Invoice { get; set; }

    [JsonPropertyName("successful_payment")]
    public SuccessfulPaymentDto? SuccessfulPayment { get; set; }

    [JsonPropertyName("refunded_payment")]
    public RefundedPaymentDto? RefundedPayment { get; set; }

    [JsonPropertyName("users_shared")]
    public UsersSharedDto? UsersShared { get; set; }

    [JsonPropertyName("chat_shared")]
    public ChatSharedDto? ChatShared { get; set; }

    [JsonPropertyName("connected_website")]
    public string? ConnectedWebsite { get; set; }

    [JsonPropertyName("write_access_allowed")]
    public WriteAccessAllowedDto? WriteAccessAllowed { get; set; }

    [JsonPropertyName("passport_data")]
    public PassportDataDto? PassportData { get; set; }

    [JsonPropertyName("proximity_alert_triggered")]
    public ProximityAlertTriggeredDto? ProximityAlertTriggered { get; set; }

    [JsonPropertyName("boost_added")]
    public ChatBoostAddedDto? BoostAdded { get; set; }

    [JsonPropertyName("chat_background_set")]
    public ChatBackgroundDto? ChatBackgroundSet { get; set; }

    [JsonPropertyName("forum_topic_created")]
    public ForumTopicCreatedDto? ForumTopicCreated { get; set; }

    [JsonPropertyName("forum_topic_edited")]
    public ForumTopicEditedDto? ForumTopicEdited { get; set; }

    [JsonPropertyName("forum_topic_closed")]
    public ForumTopicClosedDto? ForumTopicClosed { get; set; }

    [JsonPropertyName("forum_topic_reopened")]
    public ForumTopicReopenedDto? ForumTopicReopened { get; set; }

    [JsonPropertyName("general_forum_topic_hidden")]
    public GeneralForumTopicHiddenDto? GeneralForumTopicHidden { get; set; }

    [JsonPropertyName("general_forum_topic_unhidden")]
    public GeneralForumTopicUnhiddenDto? GeneralForumTopicUnhidden { get; set; }

    [JsonPropertyName("giveaway_created")]
    public GiveawayCreatedDto? GiveawayCreated { get; set; }

    [JsonPropertyName("giveaway")]
    public GiveawayDto? Giveaway { get; set; }

    [JsonPropertyName("giveaway_winners")]
    public GiveawayWinnersDto? GiveawayWinners { get; set; }

    [JsonPropertyName("giveaway_completed")]
    public GiveawayCompletedDto? GiveawayCompleted { get; set; }

    [JsonPropertyName("video_chat_scheduled")]
    public VideoChatScheduledDto? VideoChatScheduled { get; set; }

    [JsonPropertyName("video_chat_started")]
    public VideoChatStartedDto? VideoChatStarted { get; set; }

    [JsonPropertyName("video_chat_ended")]
    public VideoChatEndedDto? VideoChatEnded { get; set; }

    [JsonPropertyName("video_chat_participants_invited")]
    public VideoChatParticipantsInvitedDto? VideoChatParticipantsInvited { get; set; }

    [JsonPropertyName("web_app_data")]
    public WebAppDataDto? WebAppData { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
