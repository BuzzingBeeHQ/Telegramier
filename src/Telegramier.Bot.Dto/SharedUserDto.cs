using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SharedUserDto
{
    [JsonPropertyName("user_id")]
    public long UserId { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("photo")]
    public PhotoSizeDto[]? Photo { get; set; }
}
