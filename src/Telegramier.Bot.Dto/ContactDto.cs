using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ContactDto
{
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("user_id")]
    public long? UserId { get; set; }

    [JsonPropertyName("vcard")]
    public string? VCard { get; set; }
}
