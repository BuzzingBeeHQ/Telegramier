using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class AnswerWebAppQueryDto
{
    [JsonPropertyName("web_app_query_id")]
    public string WebAppQueryId { get; set; }

    [JsonPropertyName("result")]
    public InlineQueryResultDto Result { get; set; }
}
