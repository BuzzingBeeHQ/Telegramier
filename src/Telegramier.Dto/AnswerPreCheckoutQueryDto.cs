using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class AnswerPreCheckoutQueryDto
{
    [JsonPropertyName("pre_checkout_query_id")]
    public string PreCheckoutQueryId { get; set; }

    [JsonPropertyName("ok")]
    public bool Ok { get; set; }

    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }
}
