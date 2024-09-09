using System.Text.Json.Serialization;

namespace Telegramier.Bot.Dto;

public class SendPollDto
{
    [JsonPropertyName("business_connection_id")]
    public string? BusinessConnectionId { get; set; }

    [JsonPropertyName("chat_id")]
    public object ChatId { get; set; }

    [JsonPropertyName("message_thread_id")]
    public int? MessageThreadId { get; set; }

    [JsonPropertyName("question")]
    public string Question { get; set; }

    [JsonPropertyName("question_parse_mode")]
    public string? QuestionParseMode { get; set; }

    [JsonPropertyName("question_entities")]
    public List<MessageEntityDto>? QuestionEntities { get; set; }

    [JsonPropertyName("options")]
    public List<InputPollOptionDto> Options { get; set; }

    [JsonPropertyName("is_anonymous")]
    public bool? IsAnonymous { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("allows_multiple_answers")]
    public bool? AllowsMultipleAnswers { get; set; }

    [JsonPropertyName("correct_option_id")]
    public int? CorrectOptionId { get; set; }

    [JsonPropertyName("explanation")]
    public string? Explanation { get; set; }

    [JsonPropertyName("explanation_parse_mode")]
    public string? ExplanationParseMode { get; set; }

    [JsonPropertyName("explanation_entities")]
    public List<MessageEntityDto>? ExplanationEntities { get; set; }

    [JsonPropertyName("open_period")]
    public int? OpenPeriod { get; set; }

    [JsonPropertyName("close_date")]
    public int? CloseDate { get; set; }

    [JsonPropertyName("is_closed")]
    public bool? IsClosed { get; set; }

    [JsonPropertyName("disable_notification")]
    public bool? DisableNotification { get; set; }

    [JsonPropertyName("protect_content")]
    public bool? ProtectContent { get; set; }

    [JsonPropertyName("message_effect_id")]
    public string? MessageEffectId { get; set; }

    [JsonPropertyName("reply_parameters")]
    public ReplyParametersDto? ReplyParameters { get; set; }

    [JsonPropertyName("reply_markup")]
    public object? ReplyMarkup { get; set; }
}
