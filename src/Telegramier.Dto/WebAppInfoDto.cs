using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class WebAppInfoDto
{
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
