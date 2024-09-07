using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class UsersSharedDto
{
    [JsonPropertyName("request_id")]
    public int RequestId { get; set; }

    [JsonPropertyName("users")]
    public List<SharedUserDto> Users { get; set; }
}
