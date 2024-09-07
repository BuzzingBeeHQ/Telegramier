using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PollAnswerDto
{
    [JsonPropertyName("poll_id")]
    public string PollId { get; set; }

    [JsonPropertyName("voter_chat")]
    public ChatDto? VoterChat { get; set; }

    [JsonPropertyName("user")]
    public UserDto? User { get; set; }

    [JsonPropertyName("option_ids")]
    public int[] OptionIds { get; set; }
}
