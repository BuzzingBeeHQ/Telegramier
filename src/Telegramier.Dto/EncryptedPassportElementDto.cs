using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class EncryptedPassportElementDto
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("data")]
    public string? Data { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("files")]
    public PassportFileDto[]? Files { get; set; }

    [JsonPropertyName("front_side")]
    public PassportFileDto? FrontSide { get; set; }

    [JsonPropertyName("reverse_side")]
    public PassportFileDto? ReverseSide { get; set; }

    [JsonPropertyName("selfie")]
    public PassportFileDto? Selfie { get; set; }

    [JsonPropertyName("translation")]
    public PassportFileDto[]? Translation { get; set; }

    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}
