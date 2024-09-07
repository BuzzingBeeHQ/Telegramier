using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class AnswerCallbackQueryDto
{
    [JsonPropertyName("callback_query_id")]
    public string CallbackQueryId { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("show_alert")]
    public bool? ShowAlert { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("cache_time")]
    public int? CacheTime { get; set; }
}
