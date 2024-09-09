using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class VideoChatParticipantsInvitedDto
{
    [JsonPropertyName("users")]
    public UserDto[] Users { get; set; }
}
