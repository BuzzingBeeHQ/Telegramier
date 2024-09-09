using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetUserProfilePhotosDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    [JsonPropertyName("limit")]
    public int? Limit { get; set; }
}
