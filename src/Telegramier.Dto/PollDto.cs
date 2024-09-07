using System.Text.Json.Serialization;

namespace Telegramier.Dto;

public class PollDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("question")]
    public string Question { get; set; }

    [JsonPropertyName("question_entities")]
    public List<MessageEntityDto>? QuestionEntities { get; set; }

    [JsonPropertyName("options")]
    public List<PollOptionDto> Options { get; set; }

    [JsonPropertyName("total_voter_count")]
    public int TotalVoterCount { get; set; }

    [JsonPropertyName("is_closed")]
    public bool IsClosed { get; set; }

    [JsonPropertyName("is_anonymous")]
    public bool IsAnonymous { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("allows_multiple_answers")]
    public bool AllowsMultipleAnswers { get; set; }

    [JsonPropertyName("correct_option_id")]
    public int? CorrectOptionId { get; set; }

    [JsonPropertyName("explanation")]
    public string? Explanation { get; set; }

    [JsonPropertyName("explanation_entities")]
    public List<MessageEntityDto>? ExplanationEntities { get; set; }

    [JsonPropertyName("open_period")]
    public int? OpenPeriod { get; set; }

    [JsonPropertyName("close_date")]
    public int? CloseDate { get; set; }
}
