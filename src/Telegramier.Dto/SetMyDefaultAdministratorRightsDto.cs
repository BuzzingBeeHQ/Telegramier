using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetMyDefaultAdministratorRightsDto
{
    [JsonPropertyName("rights")]
    public ChatAdministratorRightsDto? Rights { get; set; }

    [JsonPropertyName("for_channels")]
    public bool? ForChannels { get; set; }
}
