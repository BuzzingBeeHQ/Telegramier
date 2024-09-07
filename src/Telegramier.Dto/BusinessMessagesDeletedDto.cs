using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class BusinessMessagesDeletedDto
{
    [JsonPropertyName("business_connection_id")]
    public string BusinessConnectionId { get; set; }

    [JsonPropertyName("chat")]
    public ChatDto Chat { get; set; }

    [JsonPropertyName("message_ids")]
    public int[] MessageIds { get; set; }
}
