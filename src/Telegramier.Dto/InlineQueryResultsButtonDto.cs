using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class InlineQueryResultsButtonDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("web_app")]
    public WebAppInfoDto? WebApp { get; set; }

    [JsonPropertyName("start_parameter")]
    public string? StartParameter { get; set; }
}
