using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class PollOptionDto
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("text_entities")]
    public MessageEntityDto[]? TextEntities { get; set; }

    [JsonPropertyName("voter_count")]
    public int VoterCount { get; set; }
}
