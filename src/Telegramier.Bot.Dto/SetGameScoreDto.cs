using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetGameScoreDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("force")]
    public bool? Force { get; set; }

    [JsonPropertyName("disable_edit_message")]
    public bool? DisableEditMessage { get; set; }

    [JsonPropertyName("chat_id")]
    public int? ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int? MessageId { get; set; }

    [JsonPropertyName("inline_message_id")]
    public string? InlineMessageId { get; set; }
}
