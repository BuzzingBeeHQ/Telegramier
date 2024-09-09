using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ResponseDto<TResult>
{
    [JsonPropertyName("ok")]
    public bool Ok { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("result")]
    public TResult? Result { get; set; }
}