using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SetWebhookDto
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("certificate")]
    public InputFileDto? Certificate { get; set; }

    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }

    [JsonPropertyName("max_connections")]
    public int? MaxConnections { get; set; }

    [JsonPropertyName("allowed_updates")]
    public List<string>? AllowedUpdates { get; set; }

    [JsonPropertyName("drop_pending_updates")]
    public bool? DropPendingUpdates { get; set; }

    [JsonPropertyName("secret_token")]
    public string? SecretToken { get; set; }
}
