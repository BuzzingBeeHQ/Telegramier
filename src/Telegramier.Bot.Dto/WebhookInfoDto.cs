using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class WebhookInfoDto
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("has_custom_certificate")]
    public bool HasCustomCertificate { get; set; }

    [JsonPropertyName("pending_update_count")]
    public int PendingUpdateCount { get; set; }

    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("last_error_date")]
    public int? LastErrorDate { get; set; }

    [JsonPropertyName("last_error_message")]
    public string? LastErrorMessage { get; set; }

    [JsonPropertyName("last_synchronization_error_date")]
    public int? LastSynchronizationErrorDate { get; set; }

    [JsonPropertyName("max_connections")]
    public int? MaxConnections { get; set; }

    [JsonPropertyName("allowed_updates")]
    public string[]? AllowedUpdates { get; set; }
}
