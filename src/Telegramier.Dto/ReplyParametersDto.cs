using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class ReplyParametersDto
{
    [JsonPropertyName("message_id")]
    public int MessageId { get; set; }

    [JsonPropertyName("chat_id")]
    public string? ChatId { get; set; }

    [JsonPropertyName("allow_sending_without_reply")]
    public bool? AllowSendingWithoutReply { get; set; }

    [JsonPropertyName("quote")]
    public string? Quote { get; set; }

    [JsonPropertyName("quote_parse_mode")]
    public string? QuoteParseMode { get; set; }

    [JsonPropertyName("quote_entities")]
    public List<MessageEntityDto>? QuoteEntities { get; set; }

    [JsonPropertyName("quote_position")]
    public int? QuotePosition { get; set; }
}
