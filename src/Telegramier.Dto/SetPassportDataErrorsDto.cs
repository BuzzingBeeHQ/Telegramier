using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class SetPassportDataErrorsDto
{
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("errors")]
    public PassportElementErrorDto[] Errors { get; set; }
}
