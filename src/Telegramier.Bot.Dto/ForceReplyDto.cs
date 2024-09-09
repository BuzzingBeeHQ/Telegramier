using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class ForceReplyDto
{
    [JsonPropertyName("force_reply")]
    public bool ForceReply { get; set; }

    [JsonPropertyName("input_field_placeholder")]
    public string? InputFieldPlaceholder { get; set; }

    [JsonPropertyName("selective")]
    public bool? Selective { get; set; }
}
