using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PassportDataDto
{
    [JsonPropertyName("data")]
    public EncryptedPassportElementDto[] Data { get; set; }

    [JsonPropertyName("credentials")]
    public EncryptedCredentialsDto Credentials { get; set; }
}
