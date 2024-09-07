using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class CallbackQueryDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("from")]
    public UserDto From { get; set; }

    [JsonPropertyName("message")]
    public MaybeInaccessibleMessageDto? Message { get; set; }

    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }

    [JsonPropertyName("chat_instance")]
    public string ChatInstance { get; set; }

    [JsonPropertyName("data")]
    public string? Data { get; set; }

    [JsonPropertyName("game_short_name")]
    public string? GameShortName { get; set; }
}
