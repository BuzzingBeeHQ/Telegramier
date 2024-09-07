using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class MenuButtonWebAppDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("web_app")]
    public WebAppInfoDto WebApp { get; set; }
}
