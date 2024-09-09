using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UpdateDto
{
    [JsonPropertyName("update_id")]
    public int UpdateId { get; set; }

    [JsonPropertyName("message")]
    public MessageDto? Message { get; set; }

    [JsonPropertyName("edited_message")]
    public MessageDto? EditedMessage { get; set; }

    [JsonPropertyName("channel_post")]
    public MessageDto? ChannelPost { get; set; }

    [JsonPropertyName("edited_channel_post")]
    public MessageDto? EditedChannelPost { get; set; }

    [JsonPropertyName("business_connection")]
    public BusinessConnectionDto? BusinessConnection { get; set; }

    [JsonPropertyName("business_message")]
    public MessageDto? BusinessMessage { get; set; }

    [JsonPropertyName("edited_business_message")]
    public MessageDto? EditedBusinessMessage { get; set; }

    [JsonPropertyName("deleted_business_messages")]
    public BusinessMessagesDeletedDto? DeletedBusinessMessages { get; set; }

    [JsonPropertyName("message_reaction")]
    public MessageReactionUpdatedDto? MessageReaction { get; set; }

    [JsonPropertyName("message_reaction_count")]
    public MessageReactionCountUpdatedDto? MessageReactionCount { get; set; }

    [JsonPropertyName("inline_query")]
    public InlineQueryDto? InlineQuery { get; set; }

    [JsonPropertyName("chosen_inline_result")]
    public ChosenInlineResultDto? ChosenInlineResult { get; set; }

    [JsonPropertyName("callback_query")]
    public CallbackQueryDto? CallbackQuery { get; set; }

    [JsonPropertyName("shipping_query")]
    public ShippingQueryDto? ShippingQuery { get; set; }

    [JsonPropertyName("pre_checkout_query")]
    public PreCheckoutQueryDto? PreCheckoutQuery { get; set; }

    [JsonPropertyName("purchased_paid_media")]
    public PaidMediaPurchasedDto? PurchasedPaidMedia { get; set; }

    [JsonPropertyName("poll")]
    public PollDto? Poll { get; set; }

    [JsonPropertyName("poll_answer")]
    public PollAnswerDto? PollAnswer { get; set; }

    [JsonPropertyName("my_chat_member")]
    public ChatMemberUpdatedDto? MyChatMember { get; set; }

    [JsonPropertyName("chat_member")]
    public ChatMemberUpdatedDto? ChatMember { get; set; }

    [JsonPropertyName("chat_join_request")]
    public ChatJoinRequestDto? ChatJoinRequest { get; set; }

    [JsonPropertyName("chat_boost")]
    public ChatBoostUpdatedDto? ChatBoost { get; set; }

    [JsonPropertyName("removed_chat_boost")]
    public ChatBoostRemovedDto? RemovedChatBoost { get; set; }
}
