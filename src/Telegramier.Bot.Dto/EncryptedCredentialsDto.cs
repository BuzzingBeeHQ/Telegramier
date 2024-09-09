using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class EncryptedCredentialsDto
{
    [JsonPropertyName("data")]
    public string Data { get; set; }

    [JsonPropertyName("hash")]
    public string Hash { get; set; }

    [JsonPropertyName("secret")]
    public string Secret { get; set; }
}
