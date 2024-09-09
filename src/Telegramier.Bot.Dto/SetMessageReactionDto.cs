using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetMessageReactionDto
{
    [JsonPropertyName("chat_id")]
    public string ChatId { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("reaction")]
    public List<ReactionTypeDto>? Reaction { get; set; }

    [JsonPropertyName("is_big")]
    public bool? IsBig { get; set; }
}
