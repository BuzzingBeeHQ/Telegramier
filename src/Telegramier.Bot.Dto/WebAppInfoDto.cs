using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class WebAppInfoDto
{
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
