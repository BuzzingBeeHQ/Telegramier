using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ResponseParametersDto
{
    [JsonPropertyName("migrate_to_chat_id")]
    public long? MigrateToChatId { get; set; }

    [JsonPropertyName("retry_after")]
    public int? RetryAfter { get; set; }
}
