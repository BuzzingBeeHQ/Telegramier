using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class GetMyDefaultAdministratorRightsDto
{
    [JsonPropertyName("for_channels")]
    public bool? ForChannels { get; set; }
}
