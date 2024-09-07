using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SendContactDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("vcard")]
    public string? VCard { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    [JsonPropertyName("reply_parameters")]
    public ReplyParametersDto? ReplyParameters { get; set; }

    [JsonPropertyName("reply_markup")]
    public object? ReplyMarkup { get; set; }
}
