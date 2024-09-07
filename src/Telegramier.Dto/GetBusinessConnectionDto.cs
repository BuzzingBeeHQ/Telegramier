using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class GetBusinessConnectionDto
{
    [JsonPropertyName("business_connection_id")]
    public string BusinessConnectionId { get; set; }
}
