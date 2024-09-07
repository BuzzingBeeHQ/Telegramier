using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class KeyboardButtonRequestUsersDto
{
    [JsonPropertyName("request_id")]
    public int RequestId { get; set; }

    [JsonPropertyName("user_is_bot")]
    public bool? UserIsBot { get; set; }

    [JsonPropertyName("user_is_premium")]
    public bool? UserIsPremium { get; set; }

    [JsonPropertyName("max_quantity")]
    public int? MaxQuantity { get; set; }

    [JsonPropertyName("request_name")]
    public bool? RequestName { get; set; }

    [JsonPropertyName("request_username")]
    public bool? RequestUsername { get; set; }

    [JsonPropertyName("request_photo")]
    public bool? RequestPhoto { get; set; }
}
