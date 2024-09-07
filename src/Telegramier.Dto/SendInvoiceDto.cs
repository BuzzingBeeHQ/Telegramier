using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SendInvoiceDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("payload")]
    public string Payload { get; set; }

    [JsonPropertyName("provider_token")]
    public string? ProviderToken { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("prices")]
    public List<LabeledPriceDto> Prices { get; set; }

    [JsonPropertyName("max_tip_amount")]
    public int? MaxTipAmount { get; set; }

    [JsonPropertyName("suggested_tip_amounts")]
    public List<int>? SuggestedTipAmounts { get; set; }

    [JsonPropertyName("start_parameter")]
    public string? StartParameter { get; set; }

    [JsonPropertyName("provider_data")]
    public string? ProviderData { get; set; }

    [JsonPropertyName("photo_url")]
    public string? PhotoUrl { get; set; }

    [JsonPropertyName("photo_size")]
    public int? PhotoSize { get; set; }

    [JsonPropertyName("photo_width")]
    public int? PhotoWidth { get; set; }

    [JsonPropertyName("photo_height")]
    public int? PhotoHeight { get; set; }

    [JsonPropertyName("need_name")]
    public bool? NeedName { get; set; }

    [JsonPropertyName("need_phone_number")]
    public bool? NeedPhoneNumber { get; set; }

    [JsonPropertyName("need_email")]
    public bool? NeedEmail { get; set; }

    [JsonPropertyName("need_shipping_address")]
    public bool? NeedShippingAddress { get; set; }

    [JsonPropertyName("send_phone_number_to_provider")]
    public bool? SendPhoneNumberToProvider { get; set; }

    [JsonPropertyName("send_email_to_provider")]
    public bool? SendEmailToProvider { get; set; }

    [JsonPropertyName("is_flexible")]
    public bool? IsFlexible { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    [JsonPropertyName("reply_parameters")]
    public ReplyParametersDto? ReplyParameters { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }
}
