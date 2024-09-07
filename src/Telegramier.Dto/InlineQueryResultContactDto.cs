using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultContactDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("vcard")]
    public string? VCard { get; set; }

    [JsonPropertyName("reply_markup")]
    public InlineKeyboardMarkupDto? ReplyMarkup { get; set; }

    [JsonPropertyName("input_message_content")]
    public InputMessageContentDto? InputMessageContent { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("thumbnail_width")]
    public int? ThumbnailWidth { get; set; }

    [JsonPropertyName("thumbnail_height")]
    public int? ThumbnailHeight { get; set; }
}
