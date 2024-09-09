using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class MessageReactionUpdatedDto
{
    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("user")]
    public UserDto? User { get; set; }

    [JsonPropertyName("actor_chat")]
    public ChatDto? ActorChat { get; set; }

    [JsonPropertyName("date")]
    public int Date { get; set; }

    [JsonPropertyName("old_reaction")]
    public ReactionTypeDto[] OldReaction { get; set; }

    [JsonPropertyName("new_reaction")]
    public ReactionTypeDto[] NewReaction { get; set; }
}
