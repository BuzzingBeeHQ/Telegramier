using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ChosenInlineResultDto
{
    [JsonPropertyName("result_id")]
    public string ResultId { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("location")]
    public LocationDto? Location { get; set; }

    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }
}
