using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class UserProfilePhotosDto
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("photos")]
    public PhotoSizeDto[][] Photos { get; set; }
}
